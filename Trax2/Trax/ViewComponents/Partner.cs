using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Data;


namespace Trax.ViewComponents
{
    public class Partner : ViewComponent
    {
        private readonly AppDbContext _context;
        public Partner(AppDbContext context)
        {
            _context = context;
        }

        //public ViewComponentResult Invoke()
        //{
        //    List<Trax.Models.Partner> partners = _context.Partners.ToList();
        //    return View(partners);
        //}
    }
}
