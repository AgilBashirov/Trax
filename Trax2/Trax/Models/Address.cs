using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Icon { get; set; }

        [MaxLength(50)]
        public string Info1 { get; set; }

        [MaxLength(50)]
        public string Info2 { get; set; }
    }
}
