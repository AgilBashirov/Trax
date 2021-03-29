using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.Areas.Admin.ViewModels
{
    public class VmAbout
    {
        //for crud
        public Universal Universal { get; set; }
        public SkillSet SkillSet { get; set; }
        public Process Process { get; set; }
        public List<SkillSet> SkillSets { get; set; }


        public List<User> Users { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Process> Processes { get; set; }
    }
}
