﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class SaveCompanyDTO
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int ManagerID { get; set; }
    }
}
