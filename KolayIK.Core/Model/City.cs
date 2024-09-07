using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class City: BaseClass
    {
        public string CityName { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public List<County> County { get; set; }
        public List<AddressInfo> AddressInfo { get; set; }
    }
}
