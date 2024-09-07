using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Experience: BaseClass
    {
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Position Position { get; set; }
        public int PositionID { get; set; }
        public Resume Resume { get; set; }
        public int ResumeID { get; set; }
    }
}
