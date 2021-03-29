using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.ViewModels
{
    public class VmGallery : VmBase
    {
        public List<Gallery> Galleries { get; set; }
        public List<GalleryType> GalleryTypes { get; set; }
        public List<GalleryToType> GalleryToTypes { get; set; }
    }
}
