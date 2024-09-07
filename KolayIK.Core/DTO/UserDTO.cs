namespace KolayIK.Core.DTO
{
    public class UserDTO
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int PositionID { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public int GenderID { get; set; }
        public int AddressInfoID { get; set; } 
        public string Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }    
    }
}
