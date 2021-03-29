using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.ViewModels
{
    public class VmHome: VmBase
    {
        public List<Partner> Partners { get; set; }
        public List<Process> Processes { get; set; }
        public List<User> Users { get; set; }
        public List<PeopleSay> PeopleSays { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Mobile> Mobiles { get; set; }
        public Counter Counter { get; set; }
        public List<Pricing> Pricings { get; set; }
        public List<PricingTable> PricingTables { get; set; }
    }
}
