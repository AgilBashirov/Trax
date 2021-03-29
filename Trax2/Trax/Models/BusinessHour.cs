using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class BusinessHour
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Info { get; set; }
        [MaxLength(20)]
        public string Date { get; set; }
    }
}
