using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.ViewModels
{
    public class VmContact : VmBase
    {
        public Contact Contact { get; set; }
        public List<Address> Address { get; set; }
    }
}
