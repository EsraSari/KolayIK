using KolayIK.Core.DTO;
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
    public class EmergencyPersonRepository : Repository<EmergencyPerson>, IEmergencyPersonRepository
    {
        public EmergencyPersonRepository(KolayIKDBContext context) : base(context)
        {
        }

        public async Task<EmergencyPersonDTO> GetEmergecyPersonByEmployeeIDAsync(int employeeID)
        {
            var emergencyPerson = await KolayIKDBContext.EmergencyPersons
                .FirstOrDefaultAsync(r => r.EmployeeID == employeeID);

            if (emergencyPerson == null)
            {
                return null;
            }

            return new EmergencyPersonDTO
            {
                FirstName = emergencyPerson.FirstName,
                LastName = emergencyPerson.LastName,
                Email = emergencyPerson.Email,
                Phone = emergencyPerson.Phone
            };
        }

        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }

}
