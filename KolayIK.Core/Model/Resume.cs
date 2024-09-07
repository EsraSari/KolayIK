using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Resume : BaseClass
    {
        public AppUser User { get; set; }
        public int UserID { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; }
        public List<Experience> WorkExperiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Certificate> Certificates { get; set; }
    }
}
