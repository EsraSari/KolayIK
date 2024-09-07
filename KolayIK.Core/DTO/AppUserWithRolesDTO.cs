using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class AppUserWithRolesDTO
    {
        public AppUser User { get; set; }
        public IList<string> Roles { get; set; }
    }

}
