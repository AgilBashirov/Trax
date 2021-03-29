using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.ViewModels
{
    public class VmBlog:VmBase
    {
        public Blog Blog { get; set; }
        public IList<Blog> Blogs { get; set; }
        public List<Category> Categories { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Tag> Tags { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }



    }
}
