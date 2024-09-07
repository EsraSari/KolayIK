using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Certificate: BaseClass
    {
        public string Name { get; set; }
        public string IssuedBy { get; set; } 
        public DateTime IssueDate { get; set; } 
        public DateTime? ExpiryDate { get; set; }
        public string Description { get; set; } 
        public Resume Resume { get; set; }
        public int ResumeID { get; set; }
    }
}
