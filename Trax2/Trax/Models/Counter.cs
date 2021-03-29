using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Counter
    {
        [Key]
        public int Id { get; set; }
        public int StartNum { get; set; }

        [MaxLength(50)]
        public string StartTitle { get; set; }

        [MaxLength(500)]
        public string Desc { get; set; }

        public int EndNum { get; set; }

        [MaxLength(50)]
        public string EndTitle { get; set; }
    }
}
