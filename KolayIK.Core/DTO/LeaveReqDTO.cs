using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class LeaveReqDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalTime { get; set; }
        public string Description { get; set; }
        public string LeaveTypeName { get; set; }
        public string StateName { get; set; }
        public string ApproverName { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public double RemainingLeaveAfterRequest { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
