using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class SaveLeaveReqDTO
    {
        public int UserID { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; } 
        public int LeaveTypeID { get; set; }
        public int StateID { get; set; }
        public DateTime? ApprovalDate { get; set; }
    }
}
