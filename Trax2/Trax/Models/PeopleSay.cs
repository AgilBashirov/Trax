using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class PeopleSay
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Company { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(5)]
        public int StarScore { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
    }
}
