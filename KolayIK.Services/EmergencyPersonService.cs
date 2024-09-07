using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class EmergencyPersonService : IEmergencyPersonService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmergencyPersonService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<EmergencyPersonDTO> GetEmergencyPersonByIdAsync(int id)
        {
            var emergencyPerson = await unitOfWork.EmergencyPersons.GetByIDAsync(id);
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

        public async Task<IEnumerable<EmergencyPersonDTO>> GetAllEmergencyPersonAsync()
        {
            var emergencyPersons = await unitOfWork.EmergencyPersons.GetAllAsync();
            return emergencyPersons.Select(ep => new EmergencyPersonDTO
            {
                FirstName = ep.FirstName,
                LastName = ep.LastName,
                Email = ep.Email,
                Phone = ep.Phone
            });
        }

        public async Task<EmergencyPersonDTO> GetEmergecyPersonByEmployeeIDAsync(int employeeID)
        {
            var emergencyPerson = await unitOfWork.EmergencyPersons.GetEmergecyPersonByEmployeeIDAsync(employeeID);
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

        public async Task<SaveEmergencyPersonDTO> CreateEmergencyPersonAsync(SaveEmergencyPersonDTO saveEmergencyPersonDTO)
        {
            var emergencyPerson = new EmergencyPerson
            {
                FirstName = saveEmergencyPersonDTO.FirstName,
                LastName = saveEmergencyPersonDTO.LastName,
                Email = saveEmergencyPersonDTO.Email,
                Phone = saveEmergencyPersonDTO.Phone,
                EmployeeID = saveEmergencyPersonDTO.EmployeeID
            };

            await unitOfWork.EmergencyPersons.AddAsync(emergencyPerson);
            await unitOfWork.CommitAsync();

            return saveEmergencyPersonDTO;
        }

        public async Task<bool> UpdateEmergencyPersonAsync(int id, SaveEmergencyPersonDTO updatedEmergencyPersonDTO)
        {
            var emergencyPerson = await unitOfWork.EmergencyPersons.GetByIDAsync(id);
            if (emergencyPerson == null)
            {
                return false;
            }

            emergencyPerson.FirstName = updatedEmergencyPersonDTO.FirstName;
            emergencyPerson.LastName = updatedEmergencyPersonDTO.LastName;
            emergencyPerson.Email = updatedEmergencyPersonDTO.Email;
            emergencyPerson.Phone = updatedEmergencyPersonDTO.Phone;
            emergencyPerson.EmployeeID = updatedEmergencyPersonDTO.EmployeeID;
            emergencyPerson.ModifiedDate = DateTime.Now;

            await unitOfWork.CommitAsync();
            return true; 
        }



        public async Task DeleteEmergencyPersonAsync(int id)
        {
            var emergencyPerson = await unitOfWork.EmergencyPersons.GetByIDAsync(id);
            if (emergencyPerson == null)
            {
                return;
            }

            unitOfWork.EmergencyPersons.Remove(emergencyPerson);
            await unitOfWork.CommitAsync();
        }
    }

}
