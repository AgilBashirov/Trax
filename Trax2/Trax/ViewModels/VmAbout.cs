using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.ViewModels
{
    public class VmAbout : VmBase
    {
        public List<SkillSet> SkillSets { get; set; }
        public List<User> Users { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Process> Processes { get; set; }
       

    }

}
