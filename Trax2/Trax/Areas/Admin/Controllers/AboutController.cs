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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        
        public AboutController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;

        }
        public IActionResult Index()
        {
            VmAbout model = new VmAbout()
            {
                SkillSets = _context.SkillSets.ToList(),
                Users = _context.User.ToList(),
                Partners = _context.Partners.ToList(),
                Processes = _context.Process.ToList(),
                //Universals = _context.Universal.ToList()
            };
            

            return View(model);
        }

        //SkillSet
        public IActionResult CreateSkillSet()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateSkillSet(SkillSet skill)
        {
              if (ModelState.IsValid)
                {

                    _context.SkillSets.Add(skill);
                    _context.SaveChanges();
                    return RedirectToAction("Index");

                }
              else
                {
                   
                    return View(skill);
                }
        }

        public IActionResult UpdateSkillSet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            SkillSet skill = _context.SkillSets.Find(Id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        [HttpPost]
        public IActionResult UpdateSkillSet(SkillSet skill)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(skill).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skill);
        }

        public IActionResult DeleteSkillSet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            SkillSet skill = _context.SkillSets.Find(Id);
            if (skill == null)
            {
                return NotFound();
            }

            _context.SkillSets.Remove(skill);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        //Process
        public IActionResult CreateProcess()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateProcess(Process process)
        {
            if (ModelState.IsValid)
            {

                _context.Process.Add(process);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {

                return View(process);
            }
        }

        public IActionResult UpdateProcess(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            Process process = _context.Process.Find(Id);
            if (process == null)
            {
                return NotFound();
            }

            return View(process);
        }

        [HttpPost]
        public IActionResult UpdateProcess(Process process)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(process).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(process);
        }

        public IActionResult DeleteProcess(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            Process process = _context.Process.Find(Id);
            if (process == null)
            {
                return NotFound();
            }

            _context.Process.Remove(process);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Users

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {

                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine("wwwroot/Uploads/Images", fileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.Image = fileName;


                            _context.User.Add(model);
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
                        _context.SaveChanges();

                        return RedirectToAction("Index");

                    }
                }
                else
                {
                    ModelState.AddModelError("ImageFile","You must add user's picture!");

                }



            }
            
            return View(model);
        }


        public IActionResult UpdateUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            User user = _context.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult UpdateUser(User model)
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

        public IActionResult DeleteUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = _context.User.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            //delete user's image
            if (user.Image != null)
            {
                string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", user.Image);
                if (System.IO.File.Exists(oldFilePath))
                {
                    System.IO.File.Delete(oldFilePath);
                }
            }
            

           

            _context.User.Remove(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }








    }
}
