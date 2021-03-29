using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.ViewModels
{
    public class VmBase
    {
        public Setting Setting { get; set; }
        public List<Service> Services { get; set; }
        public List<BusinessHour> BusinessHours { get; set; }
        public List<Universal> Universals { get; set; }
        public List<Blog> RecentBlogs { get; set; }
        public List<Social> Socials { get; set; }

    }
}
