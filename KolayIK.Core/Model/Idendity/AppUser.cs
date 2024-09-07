using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KolayIK.Core.Modal.Idendity
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Position Position { get; set; }
        public int PositionID { get; set; }
        public DateTime HireDate { get; set; }
        public double RemainingLeave { get; set; } = 14;
        public double Salary { get; set; }
        public Gender Gender { get; set; }
        public int GenderID { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public int? AddressInfoID { get; set; }
        public int EmergencyPersonID { get; set; }
        public EmergencyPerson EmergencyPerson { get; set; }
        public Company Company { get; set; }
        public int? CompanyID { get; set; }
        public bool Status { get; set; } = true;
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public List<LeaveRequest> LeaveRequests { get; set; }
        public List<LeaveRequest> ApprovedLeaveReq { get; set; }
        public List<ExpenseRequest> ExpenseRequests { get; set; }
        public List<ExpenseRequest> ApprovedExpenseReq { get; set; }
        public Resume Resume { get; set; }
        public List<Company> ManagedCompanies { get; set; }
        public List<Company> ApprovedCompanies { get; set; }
        public int? ManagerID { get; set; }

    }
}
