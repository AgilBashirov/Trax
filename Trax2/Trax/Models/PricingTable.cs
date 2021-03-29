using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class PricingTable
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Info { get; set; }
        [MaxLength(150)]
        public string Icon { get; set; }
        public int PricingId { get; set; }
        [ForeignKey("PricingId")]
        public Pricing Pricing { get; set; }
    }
}
