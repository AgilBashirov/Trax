using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Company { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
