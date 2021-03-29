using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trax.Data;
using Trax.ViewModels;

namespace Trax.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new VmContact()
            {
                Contact =_context.Contacts.FirstOrDefault(),
                Address=_context.Address.ToList(),
                
                //for layout
                RecentBlogs = _context.Blogs.OrderByDescending(o => o.AddedDate).Take(3).ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Services = _context.Services.ToList(),
                Socials = _context.Socials.ToList(),
                BusinessHours = _context.BusinessHours.ToList(),
                Universals = _context.Universal.ToList()
            };
            return View(model);
        }
    }
}
