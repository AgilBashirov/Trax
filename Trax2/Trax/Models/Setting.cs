using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo1 { get; set; }
        [MaxLength(250)]
        public string Logo2 { get; set; }
        [MaxLength(250)]
        public string Content { get; set; }
        [MaxLength(250)]
        public string Icon { get; set; }
        [MaxLength(20)]
        
        public string FooterPhone { get; set; }
        [MaxLength(250)]
        public string FooterEmail { get; set; }
    }
}
