using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Country: BaseClass
    {
        public string CountryName { get; set; }
        public List<City> City { get; set; }
        public List<AddressInfo> AddressInfo { get; set; }
    }
}
