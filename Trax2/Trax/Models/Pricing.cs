using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Subtitle { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        [MaxLength(10)]
        public string Discount { get; set; }
        public bool IsYearly { get; set; }
        public List<PricingTable> PricingTables { get; set; }
    }
}
