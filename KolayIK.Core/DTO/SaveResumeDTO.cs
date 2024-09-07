using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class SaveResumeDTO
    {
        public int UserID { get; set; }
        public string Summary { get; set; }
        public List<SaveExperienceDTO> WorkExperiences { get; set; }
        public List<SaveEducationDTO> Educations { get; set; }
        public List<SaveCertificateDTO> Certificates { get; set; }
        public List<string> Skills { get; set; }
    }

}
