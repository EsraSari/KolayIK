using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class County : BaseClass
    {
        public int CityID { get; set; }
        public City City { get; set; }
        public string CountyName { get; set; }
        public List<AddressInfo> AddressInfo { get; set; }
    }
}
