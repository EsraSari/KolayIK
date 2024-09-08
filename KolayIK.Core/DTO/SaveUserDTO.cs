namespace KolayIK.Core.DTO
{
    public class SaveUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderID { get; set; }
        public int CompanyID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int PositionID { get; set; }
        public List<string> Roles { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public SaveAddressInfoDTO Address { get; set; }
        public double RemainingLeave { get; set; }
        public int? ManagerID { get; set; }

    }
}
