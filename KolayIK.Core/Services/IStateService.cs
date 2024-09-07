﻿using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetAllStates();
    }

}
