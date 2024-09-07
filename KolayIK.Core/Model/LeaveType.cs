using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class LeaveType: BaseClass
    {
        public string LeaveTypeName { get; set; }
        public List<LeaveRequest> LeaveRequests{ get; set; }
    }
}
