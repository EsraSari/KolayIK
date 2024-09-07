using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IEmergencyPersonService
    {
        Task<EmergencyPersonDTO> GetEmergencyPersonByIdAsync(int id);
        Task<IEnumerable<EmergencyPersonDTO>> GetAllEmergencyPersonAsync();
        Task<EmergencyPersonDTO> GetEmergecyPersonByEmployeeIDAsync(int employeeID);
        Task<SaveEmergencyPersonDTO> CreateEmergencyPersonAsync(SaveEmergencyPersonDTO emergencyPersonDTO);
        Task<bool> UpdateEmergencyPersonAsync(int id, SaveEmergencyPersonDTO updatedEmergencyPer);
        Task DeleteEmergencyPersonAsync(int id);
    }
}
