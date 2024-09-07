using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Position : BaseClass
    {
        public string PositionName { get; set; }
        public List<AppUser> Users{ get; set; }
        public List<Experience> Experiences { get; set; }
    }
}
