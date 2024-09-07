using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class AddressDTO
    {
        public int ID { get; set; }
        public string? CountryName { get; set; }
        public string? CityName { get; set; }
        public string? CountyName { get; set; }
        public string AddressDetail { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
