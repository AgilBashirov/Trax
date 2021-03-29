using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class SkillSet
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30),Required (ErrorMessage="Please, write Name!")]
        public string Name { get; set; }
        public int Persentage { get; set; }
    }
}
