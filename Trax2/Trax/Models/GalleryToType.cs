using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trax.Models
{
    public class GalleryToType
    {
        [Key]
        public int Id { get; set; }
        public int GalleryTypeId { get; set; }
        [ForeignKey("GalleryTypeId")]
        public GalleryType GallaryType { get; set; }

        public int GalleryId { get; set; }
        [ForeignKey("GalleryId")]
        public Gallery Gallary { get; set; }
    }
}
