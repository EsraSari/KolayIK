using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(KolayIKDBContext context) : base(context)
        {
        }

        public async Task<AppUser> GetByEmailAsync(string email)
        {
            return await KolayIKDBContext.Users.SingleOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<AppUser>> GetAllUsersByManagerIDAsync(int managerID)
        {
            return await KolayIKDBContext.Users
                .Where(x => x.ManagerID == managerID)
                .Include(u => u.AddressInfo)
                .Include(g => g.Gender)
                .Include(c => c.AddressInfo.Country)
                .Include(c => c.AddressInfo.City)
                .Include(c => c.AddressInfo.County)
                .Include(p => p.Position)
                .Include(g => g.Gender)
                .Include(c => c.Company)
                .Include(e => e.EmergencyPerson)
                .ToListAsync();
        }

        public async Task<IEnumerable<AppUser>> GetAllUsersByRole(int roleID)
        {
            return await KolayIKDBContext.UserRoles
                .Where(c => c.RoleId == roleID)
                .Join(KolayIKDBContext.Users, ur => ur.UserId, u => u.Id, (ur, u) => u)
                .Include(u => u.AddressInfo)
                .Include(c => c.AddressInfo.Country)
                .Include(c => c.AddressInfo.City)
                .Include(c => c.AddressInfo.County)
                .Include(p => p.Position)
                .Include(g => g.Gender)
                .Include(e => e.EmergencyPerson)
                .Include(c => c.Company)
                .ToListAsync();
        }
        public async Task<EmployeeDTO> GetUserWithRoleByUserID(int userID)
        {
            var userWithRole = await KolayIKDBContext.UserRoles
                .Where(ur => ur.UserId == userID)
                .Join(
                    KolayIKDBContext.Users,
                    ur => ur.UserId,
                    u => u.Id,
                    (ur, u) => new
                    {
                        User = u,
                        RoleID = ur.RoleId
                    }
                )
                .Select(result => new EmployeeDTO
                {
                    Id = result.User.Id,
                    CompanyID = result.User.CompanyID,
                    FirstName = result.User.FirstName,
                    LastName = result.User.LastName,
                    BirthDate = result.User.BirthDate,
                    PositionName = result.User.Position.PositionName,
                    HireDate = result.User.HireDate,
                    Salary = result.User.Salary,
                    GenderName = result.User.Gender.GenderName,
                    CompanyName = result.User.Company.CompanyName ?? "Bilinmiyor",
                    CountryName = result.User.AddressInfo.Country.CountryName,
                    CityName = result.User.AddressInfo.City.CityName,
                    CountyName = result.User.AddressInfo.County.CountyName,
                    EmergencyPerson = result.User.EmergencyPerson != null
                    ? $"{result.User.EmergencyPerson.FirstName} {result.User.EmergencyPerson.LastName}"
                    : "Bilinmiyor",
                    AddressDetail = result.User.AddressInfo.AddressDetail ?? "Bilinmiyor",
                    RoleID = result.RoleID,
                    AddedDate = result.User.AddedDate,
                    ModifiedDate = result.User.ModifiedDate,
                    UserName = result.User.UserName,
                    Email = result.User.Email,
                    PhoneNumber = result.User.PhoneNumber,
                    RemainingLeave = result.User.RemainingLeave
                })
                .FirstOrDefaultAsync();

            return userWithRole;
        }


        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }

}
