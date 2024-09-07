using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class State: BaseClass
    {
        public string StateName { get; set; }
        public List<LeaveRequest> LeaveRequests { get; set; }
        public List<ExpenseRequest> ExpenseRequests{ get; set; }
        public List<Company> Companies { get; set; }
    }
}
