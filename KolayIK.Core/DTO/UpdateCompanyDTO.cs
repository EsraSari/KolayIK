using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class UpdateCompanyDTO
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public int StateID { get; set; }
        public DateTime? ApprovalDate { get; set; }
    }
}
