using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Trax.Data;
using Trax.Models;
using Trax.ViewModels;

namespace Trax.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController (AppDbContext context)
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
                PeopleSays=_context.PeopleSays.ToList(),
                Sliders = _context.Sliders.ToList(),
                Mobiles =_context.Mobiles.ToList(),
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
