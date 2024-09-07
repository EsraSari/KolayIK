using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PositionName { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public string GenderName{ get; set; }
        public string CompanyName { get; set; }
        public int? CompanyID { get; set; }
        public string? CountryName { get; set; }
        public string? EmergencyPerson { get; set; }
        public string? CityName { get; set; }
        public string? CountyName { get; set; }
        public string AddressDetail { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleID{ get; set; }
        public double RemainingLeave { get; set; }
    }
}
