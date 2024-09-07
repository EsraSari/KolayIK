using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Company : BaseClass
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Address{ get; set; }
        public AppUser Manager { get; set; }
        public int ManagerID { get; set; }
        public State ApprovalStatus { get; set; } 
        public int ApprovalStatusID { get; set; } = 1;
        public AppUser Approver { get; set; }
        public int ApproverID { get; set; } = 2;
        public DateTime? ApprovalDate { get; set; } = null;
        public List<Event> Events { get; set; }
        public List<AppUser> Employees { get; set; }
    }
}
