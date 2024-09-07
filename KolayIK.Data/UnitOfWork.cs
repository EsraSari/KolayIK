using KolayIK.Core.Repositories;
using KolayIK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolayIK.Data.Repositories;

namespace KolayIK.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KolayIKDBContext context;
        private UserRepository userRepository;
        private LeaveRequestRepository leaveReqRepository;
        private ExpenseRequestRepository expenseReqRepository;
        private CompanyRepository companyRepository;
        private ResumeRepository resumeRepository;
        private EducationRepository educationRepository;
        private ExperienceRepository experienceRepository;
        private CertificateRepository certificateRepository;
        private RoleRepository roleRepository;
        private StateRepository stateRepository;
        private PositionRepository positionRepository;
        private LeaveTypeRepository leaveTypeRepository;
        private EventRepository eventRepository;
        private EventTypeRepository eventTypeRepository;
        private AddressRepository addressRepository;
        private CityRepository cityRepository;
        private CountyRepository countyRepository;
        private CountryRepository countryRepository;
        private GenderRepository genderRepository;
        private EmergencyPersonRepository epRepository;

        public UnitOfWork(KolayIKDBContext _context)
        {
            context = _context;
        }

        public IUserRepository Users => userRepository = userRepository ?? new UserRepository(context);
        public IRoleRepository Roles => roleRepository = roleRepository ?? new RoleRepository(context);
        public ILeaveRequestRepository LeaveRequests => leaveReqRepository = leaveReqRepository ?? new LeaveRequestRepository(context);
        public ICompanyRepository Companies => companyRepository = companyRepository ?? new CompanyRepository(context);
        public IExpenseRequestRepository ExpenseRequests => expenseReqRepository = expenseReqRepository ?? new ExpenseRequestRepository(context);
        public IResumeRepository Resumes => resumeRepository = resumeRepository ?? new ResumeRepository(context);
        public IEducationRepository Educations => educationRepository = educationRepository ?? new EducationRepository(context);
        public IExperienceRepository Experiences => experienceRepository = experienceRepository ?? new ExperienceRepository(context);
        public ICertificateRepository Certificates => certificateRepository = certificateRepository ?? new CertificateRepository(context);
        public IStateRepository States => stateRepository = stateRepository ?? new StateRepository(context);
        public IPositionRepository Positions => positionRepository = positionRepository ?? new PositionRepository(context);
        public ILeaveTypeRepository LeaveTypes => leaveTypeRepository = leaveTypeRepository ?? new LeaveTypeRepository(context);
        public IEventRepository Events => eventRepository = eventRepository ?? new EventRepository(context);
        public IEventTypeRepository EventTypes => eventTypeRepository = eventTypeRepository ?? new EventTypeRepository(context);
        public IAddressRepository Addresses => addressRepository = addressRepository ?? new AddressRepository(context);
        public ICityRepository Cities => cityRepository = cityRepository ?? new CityRepository(context);
        public ICountyRepository Counties => countyRepository = countyRepository ?? new CountyRepository(context);
        public ICountryRepository Countries => countryRepository = countryRepository ?? new CountryRepository(context);
        public IGenderRepository Genders => genderRepository = genderRepository ?? new GenderRepository(context);
        public IEmergencyPersonRepository EmergencyPersons => epRepository = epRepository ?? new EmergencyPersonRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }

}
