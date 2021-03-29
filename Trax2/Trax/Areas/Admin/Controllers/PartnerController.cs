using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trax.Data;
using Trax.Models;

namespace Trax.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PartnerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;


        public PartnerController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;

        }

        public IActionResult Index()
        {
            List<Partner> partners = _context.Partners.ToList();
            return View(partners);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Partner model)
        {
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

                        _context.Partners.Add(model);
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

            Partner partner = _context.Partners.Find(id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        [HttpPost]
        public IActionResult Update(Partner model)
        {
            if (ModelState.IsValid)
            {

                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", model.Image);
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
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
                else
                {
                    _context.Entry(model).State = EntityState.Modified;
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

            Partner partner = _context.Partners.Find(id);

            if (partner == null)
            {
                return NotFound();
            }

            //delete blog's image
            string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", partner.Image);
            if (System.IO.File.Exists(oldFilePath))
            {
                System.IO.File.Delete(oldFilePath);
            }

            

            _context.Partners.Remove(partner);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
