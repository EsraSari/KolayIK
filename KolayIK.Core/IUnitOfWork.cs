using KolayIK.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        ILeaveRequestRepository LeaveRequests { get; }
        IExpenseRequestRepository ExpenseRequests { get; }
        ICompanyRepository Companies { get; }
        IResumeRepository Resumes { get; }
        IEducationRepository Educations { get; }
        IExperienceRepository Experiences{ get; }
        ICertificateRepository Certificates { get; }
        IStateRepository States{ get; }
        IPositionRepository Positions { get; }
        ILeaveTypeRepository LeaveTypes { get; }
        IEventRepository Events { get; }
        IEventTypeRepository EventTypes { get; }
        IAddressRepository Addresses { get; }
        ICityRepository Cities{ get; }
        ICountryRepository Countries { get; }
        ICountyRepository Counties{ get; }
        IGenderRepository Genders{ get; }
        IEmergencyPersonRepository EmergencyPersons{ get; }
        Task<int> CommitAsync();
    }
}
