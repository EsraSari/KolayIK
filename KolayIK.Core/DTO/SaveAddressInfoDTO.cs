using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class SaveAddressInfoDTO
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int CountyID { get; set; }
        public string AddressDetail { get; set; }

    }
}
