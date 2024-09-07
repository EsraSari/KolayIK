using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class ExpenseRequest: BaseClass
    {
        public AppUser User{ get; set; }
        public int UserID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public State State { get; set; } 
        public int StateID { get; set; } = 1;
        public AppUser Approver { get; set; }
        public int ApproverID { get; set; }
        public DateTime? ApprovalDate { get; set; }

    }
}
