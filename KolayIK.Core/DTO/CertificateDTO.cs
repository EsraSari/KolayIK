using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class CertificateDTO
    {
        public string Name { get; set; }
        public string IssuedBy { get; set; } 
        public DateTime IssueDate { get; set; } 
        public DateTime? ExpiryDate { get; set; } 
        public string Description { get; set; } 
    }
}
