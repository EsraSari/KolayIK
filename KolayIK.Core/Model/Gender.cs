using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Gender: BaseClass
    {
        public string GenderName { get; set; }
        public List<AppUser> Users{ get; set; }

    }
}
