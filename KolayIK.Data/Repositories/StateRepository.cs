using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(KolayIKDBContext context) : base(context)
        {
        }

        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }

}
