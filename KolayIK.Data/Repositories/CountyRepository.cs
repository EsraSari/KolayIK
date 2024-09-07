using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class CountyRepository : Repository<County>, ICountyRepository
    {
        public CountyRepository(KolayIKDBContext context) : base(context)
        {

        }
        
        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}
