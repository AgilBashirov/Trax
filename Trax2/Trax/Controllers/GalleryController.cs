using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trax.Data;
using Trax.ViewModels;

namespace Trax.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;
        public GalleryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmGallery model = new VmGallery()
            {
                Galleries = _context.Galleries.Include(g=>g.GalleryToTypes).ThenInclude(g=>g.GallaryType).ToList(),
                GalleryTypes =_context.GalleryTypes.Include(g=>g.GalleryToTypes).ThenInclude(gt=>gt.Gallary).ToList(),
                GalleryToTypes = _context.GalleryToTypes.ToList(),
                //for layout
                RecentBlogs = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Socials = _context.Socials.ToList(),
                Services = _context.Services.ToList(),
                BusinessHours = _context.BusinessHours.ToList(),
                Universals = _context.Universal.ToList()
            };
            return View(model);
        }
    }
}
