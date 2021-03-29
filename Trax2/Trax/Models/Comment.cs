using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Comment
    {
        [Key]
        public int? Id { get; set; }

        public string Desc { get; set; }
       

        public int BlogId { get; set; }
        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        public int? CommentId { get; set; }

        [ForeignKey("CommentId")]
        public Comment PartnerComment { get; set; }
        //public List<CommentToUser> CommentToUsers { get; set; }


    }
}
