﻿using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(KolayIKDBContext context) : base(context)
        {

        }
        
        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;

    }
}
