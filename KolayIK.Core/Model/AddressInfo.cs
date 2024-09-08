using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class AddressInfo: BaseClass
    {
        public int UserID { get; set; }
        public AppUser User{ get; set; }
        public Country Country { get; set; }
        public int? CountryID { get; set; }
        public City City { get; set; }
        public int? CityID { get; set; }
        public County County { get; set; }
        public int? CountyID { get; set; }
        public string AddressDetail { get; set; }
    }
}
