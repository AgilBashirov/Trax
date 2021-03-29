using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trax.Data;
using Trax.ViewModels;

namespace Trax.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {
                Partners = _context.Partners.ToList(),
                Processes = _context.Process.ToList(),
                Users = _context.User.ToList(),
                PeopleSays = _context.PeopleSays.ToList(),
                Sliders = _context.Sliders.ToList(),
                Mobiles = _context.Mobiles.ToList(),
                Counter = _context.Counter.FirstOrDefault(),
                Pricings = _context.Pricings.ToList(),
                PricingTables = _context.PricingTables.ToList(),

                //for layout
                RecentBlogs = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Socials = _context.Socials.Include(s => s.SocialToUsers).ToList(),

                Services = _context.Services.ToList(),
                BusinessHours = _context.BusinessHours.ToList(),
                Universals = _context.Universal.ToList()
            };
            return View(model);
        }
    }
}
