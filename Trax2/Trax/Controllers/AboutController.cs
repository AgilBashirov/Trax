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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new VmAbout()
            {
                SkillSets = _context.SkillSets.ToList(),
                Users = _context.User.ToList(),
                Partners = _context.Partners.ToList(),
                Processes = _context.Process.ToList(),
                //for layout
                RecentBlogs = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Services = _context.Services.ToList(),
                Socials = _context.Socials.Include(s=>s.SocialToUsers).ToList(),
                BusinessHours = _context.BusinessHours.ToList(),
                Universals = _context.Universal.ToList()
            };
            return View(model);
        }
    }
}
