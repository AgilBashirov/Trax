using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50),Required]
        public string Name { get; set; }

        [MaxLength(150),Required]
        public string Position { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Required]
        public bool IsTeamMember { get; set; }

        [Required]
        public bool Gender { get; set; }

        public List<SocialToUser> SocialToUsers { get; set; }

        public List<Blog> Blogs { get; set; }
        //public List<CommentToUser> CommentToUsers { get; set; }




    }
}
