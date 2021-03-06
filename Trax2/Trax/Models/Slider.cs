using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string UpTitle { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string SubTitle { get; set; }
        [MaxLength(250)]
        public string Desc { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        
    }
}
