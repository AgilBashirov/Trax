using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trax.Data;
using Trax.Models;
using Trax.ViewModels;

namespace Trax.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? catId, int? tagId)
        {
            IList<Blog> blog = _context.Blogs.Include(u => u.User).Include(c => c.Comments).Where(b => (catId != null ? b.CategoryId == catId : true) && (tagId !=null ? b.TagToBlogs.Any(t => t.TagId == tagId):true)).ToList();
            //if (catId != null)
            //{
            //    blog = _context.Blogs.Where(b => b.CategoryId == catId).Include(u => u.User).Include(c => c.Comments).ToList();
            //}
            //else if (tagId != null)
            //{
            //    blog = _context.Blogs.Include(u => u.User).Include(c => c.Comments).Where(t => t.TagToBlogs.Any(b => b.TagId == tagId)).ToList();
            //}
            //else
            //{
            //    blog = _context.Blogs.Include(u => u.User).Include(c => c.Comments).ToList();
            //}


            VmBlog model = new VmBlog()
            {
                Blogs = blog,



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
        public IActionResult Details(int id)
        {
            VmBlog model = new VmBlog()
            {
                Blog = _context.Blogs.Include(u => u.User).Include(c => c.Comments).FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.Include(u => u.User).Include(c => c.Comments).ToList(),
                Categories = _context.Categories.Include(b => b.Blogs).ToList(),
                Comment = _context.Comment.Where(c=>c.BlogId == id).ToList(),
                RecentBlogs=_context.Blogs.OrderByDescending(o=>o.AddedDate).Take(3).ToList(),
                Tags = _context.Tags.ToList(),


                //for layout
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
