using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trax.Areas.Admin.ViewModels;
using Trax.Data;
using Trax.Models;

namespace Trax.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public BlogController (AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            VmBlog model = new VmBlog()
            {
                Blogs = _context.Blogs.Include(u=>u.User).Include(c => c.Category).Include(tb=>tb.TagToBlogs).ThenInclude(t=>t.Tag).ToList()
            };
            return View(model);
        }
        public IActionResult Create()
        {
            List<Category> categories = _context.Categories.ToList();
            categories.Insert(0, new Category() {Id = 0, Name = "Select" });
            ViewBag.Categories = categories;

            List<Tag> tags = _context.Tags.ToList();
            ViewBag.Tags = tags;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (model.CategoryId == 0)
            {
                ModelState.AddModelError("CategoryId","You must select any category for blog!");
                List<Category> categories = _context.Categories.ToList();
                categories.Insert(0, new Category() { Id = 0, Name = "Select" });
                ViewBag.Categories = categories;

                List<Tag> tags = _context.Tags.ToList();
                ViewBag.Tags = tags;

                return View(model);
            }
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                {
                    if (model.ImageFile.Length <= 2097152)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.Image = fileName;
                        model.UserId = 3;
                        model.AddedDate = DateTime.Now;


                        _context.Blogs.Add(model);
                        _context.SaveChanges();

                        foreach (var item in model.TagIds)
                        {
                            TagToBlog tagToBlog = new TagToBlog()
                            {
                                BlogId = model.Id,
                                TagId = item
                            };
                            _context.TagToBlog.Add(tagToBlog);
                        }
                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "You can upload maximum 2Mb size file!");
                    }
                }
                else
                {
                    ModelState.AddModelError("ImageFile", "You can upload only png, jpeg and gif typed file!");
                }
            }

            return View(model);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = _context.Blogs.Include(t=>t.TagToBlogs).FirstOrDefault(b=>b.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            List<Category> categories = _context.Categories.ToList();
            categories.Insert(0, new Category() { Id = 0, Name = "Select" });
            ViewBag.Categories = categories;

            List<Tag> tags = _context.Tags.ToList();
            ViewBag.Tags = tags;

            List<int> tagIds = new List<int>();
            foreach (var item in blog.TagToBlogs)
            {
                tagIds.Add(item.TagId);
            }
            blog.TagIds = tagIds.ToArray();


            return View(blog);
        }

        [HttpPost]
        public IActionResult Update(Blog model)
        {
            if (ModelState.IsValid)
            {

                if (model.ImageFile != null)
                {
                    if (model.CategoryId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "You must select any category for blog!");
                        List<Category> categories = _context.Categories.ToList();
                        categories.Insert(0, new Category() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;

                        List<Tag> tags = _context.Tags.ToList();
                        ViewBag.Tags = tags;

                        return View(model);
                    }

                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            if (model.Image != null)
                            {
                                string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", model.Image);
                                if (System.IO.File.Exists(oldFilePath))
                                {
                                    System.IO.File.Delete(oldFilePath);
                                }
                            }

                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);

                            //model.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                                model.Image = fileName;



                            _context.Entry(model).State = EntityState.Modified;

                            //if i wanna save something static
                            _context.Entry(model).Property(a => a.AddedDate).IsModified = false;
                            _context.Entry(model).Property(a => a.UserId).IsModified = false;

                            _context.SaveChanges();

                            //for delete all tags
                            foreach (var item in _context.Blogs.Include(t => t.TagToBlogs).FirstOrDefault(b => b.Id == model.Id).TagToBlogs)
                            {
                                _context.TagToBlog.Remove(item);
                            }
                            _context.SaveChanges();


                            //for add new tag to blog
                            if (model.TagIds != null)
                            {
                                foreach (var item in model.TagIds)
                                {
                                    TagToBlog tagToBlog = new TagToBlog()
                                    {
                                        BlogId = model.Id,
                                        TagId = item
                                    };
                                    _context.TagToBlog.Add(tagToBlog);
                                }
                                _context.SaveChanges();


                            }

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("ImageFile", "You can upload maximum 2Mb size file!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "You can upload only png, jpeg and gif typed file!");
                    }
                }
                else
                {
                    if (model.CategoryId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "You must select any category for blog!");
                        List<Category> categories = _context.Categories.ToList();
                        categories.Insert(0, new Category() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;

                        List<Tag> tags = _context.Tags.ToList();
                        ViewBag.Tags = tags;

                        return View(model);
                    }

                    _context.Entry(model).State = EntityState.Modified;

                    //if i wanna save something static
                    _context.Entry(model).Property(a => a.AddedDate).IsModified = false;
                    _context.Entry(model).Property(a => a.UserId).IsModified = false;

                    _context.SaveChanges();

                    //for delete old tags
                    foreach (var item in _context.Blogs.Include(t => t.TagToBlogs).FirstOrDefault(b => b.Id == model.Id).TagToBlogs)
                    {
                        _context.TagToBlog.Remove(item);
                    }
                    _context.SaveChanges();


                    //for add new tag to blog
                    if (model.TagIds != null)
                    {
                        foreach (var item in model.TagIds)
                        {
                            TagToBlog tagToBlog = new TagToBlog()
                            {
                                BlogId = model.Id,
                                TagId = item
                            };
                            _context.TagToBlog.Add(tagToBlog);
                        }

                    }
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }

            }
            

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = _context.Blogs.Include(t=>t.TagToBlogs).FirstOrDefault(b=>b.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            //delete blog's image
            string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", blog.Image);
            if (System.IO.File.Exists(oldFilePath))
            {
                System.IO.File.Delete(oldFilePath);
            }

            //delete blog's tags
            foreach (var item in blog.TagToBlogs)
            {
                _context.TagToBlog.Remove(item);
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
