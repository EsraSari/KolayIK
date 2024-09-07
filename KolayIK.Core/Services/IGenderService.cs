﻿using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IGenderService
    {
        Task<IEnumerable<Gender>> GetAllGenders();
    }
}
