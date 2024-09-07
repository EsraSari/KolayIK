using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Services;
using KolayIK.Data;
using Microsoft.AspNetCore.Identity; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;
        private readonly SignInManager<AppUser> signInManager;
        public UserService(IUnitOfWork _unitOfWork, UserManager<AppUser> _userManager , IPasswordHasher<AppUser> _passwordHasher, SignInManager<AppUser> _signInManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
            passwordHasher = _passwordHasher;
            signInManager = _signInManager;
        }

        public async Task<IdentityResult> CreateUser(SaveUserDTO newUser)
        {
            var appUser = new AppUser
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                BirthDate = newUser.BirthDate,
                PositionID = newUser.PositionID,
                HireDate = newUser.HireDate,
                Salary = newUser.Salary,
                CompanyID = newUser.Roles.Contains("Admin") || newUser.Roles.Contains("Manager") ? null : newUser.CompanyID,
                GenderID = newUser.GenderID,
                UserName = newUser.UserName,
                AddressInfoID = newUser.Address.Id,
                Email = newUser.Email,
                NormalizedEmail = newUser.Email.ToUpper(),
                PhoneNumber = newUser.PhoneNumber,
                ManagerID = newUser.ManagerID
            };

            IdentityResult result = await userManager.CreateAsync(appUser, newUser.Password);

            if (!result.Succeeded)
            {
                return result; 
            }

            if (newUser.Address != null)
            {
                var address = new AddressInfo
                {
                    CountryID = newUser.Address.CountryID,
                    CityID = newUser.Address.CityID,
                    CountyID = newUser.Address.CountyID,
                    AddressDetail = newUser.Address.AddressDetail,
                    UserID = appUser.Id 
                };

                await unitOfWork.Addresses.AddAsync(address);
                await unitOfWork.CommitAsync();

                appUser.AddressInfoID = address.ID;
                result = await userManager.UpdateAsync(appUser);

                if (!result.Succeeded)
                {
                    var addressToRemove = await unitOfWork.Addresses.GetByIDAsync(address.ID);
                    if (addressToRemove != null)
                    {
                        unitOfWork.Addresses.Remove(addressToRemove);
                        await unitOfWork.CommitAsync();
                    }
                    await userManager.DeleteAsync(appUser);
                    return result;
                }
            }

            if (newUser.Roles != null && newUser.Roles.Count > 0)
            {
                result = await userManager.AddToRolesAsync(appUser, newUser.Roles);

                if (!result.Succeeded)
                {
                    await userManager.DeleteAsync(appUser);
                    if (newUser.Address != null)
                    {
                        var addressToRemove = await unitOfWork.Addresses.GetByIDAsync(appUser.AddressInfoID.GetValueOrDefault());
                        if (addressToRemove != null)
                        {
                            unitOfWork.Addresses.Remove(addressToRemove);
                            await unitOfWork.CommitAsync();
                        }
                    }
                    return result;
                }
            }

            await unitOfWork.CommitAsync(); 
            return result;
        }
        public async Task<AppUser> UpdateUser(AppUser userToBeUpdated, SaveUserDTO newUser)
        {
            userToBeUpdated.UserName = newUser.UserName;
            userToBeUpdated.NormalizedUserName = newUser.UserName;
            userToBeUpdated.Email = newUser.Email;
            userToBeUpdated.FirstName = newUser.FirstName;
            userToBeUpdated.LastName = newUser.LastName;
            userToBeUpdated.Salary = newUser.Salary;
            userToBeUpdated.RemainingLeave = newUser.RemainingLeave;
            await unitOfWork.CommitAsync();

            return userToBeUpdated;
        }
        public async Task DeleteUser(AppUser user)
        {
            unitOfWork.Users.Remove(user);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<AppUser>> GetAllUsers()
        {
            return await unitOfWork.Users.GetAllAsync();
        }

        public async Task<AppUser> GetUserById(int id)
        {
            return await unitOfWork.Users.GetByIDAsync(id);
        }

        public async Task<AppUser> GetUserByEmail(string email)
        {
            return await unitOfWork.Users.GetByEmailAsync(email);
        }
        public async Task<AppUserWithRolesDTO> AuthenticateUser(string email, string password)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
                return null;

            var result = await signInManager.CheckPasswordSignInAsync(user, password, false);
            if (result.Succeeded)
            {
                var roles = await userManager.GetRolesAsync(user);
                return new AppUserWithRolesDTO
                {
                    User = user,
                    Roles = roles
                };
            }

            return null;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllUsersByManagerIDAsync(int managerID)
        {
            var users = await unitOfWork.Users.GetAllUsersByManagerIDAsync(managerID);

            var employeeDTOs = new List<EmployeeDTO>();

            foreach (var user in users)
            {

                var employeeDTO = new EmployeeDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    BirthDate = user.BirthDate,
                    PositionName = user.Position.PositionName,
                    HireDate = user.HireDate,
                    Salary = user.Salary,
                    GenderName = user.Gender.GenderName,
                    CompanyName = user.Company?.CompanyName ?? "Bilinmiyor",
                    CountryName = user.AddressInfo?.Country.CountryName ?? "Bilinmiyor",
                    CityName = user.AddressInfo?.City.CityName ?? "Bilinmiyor",
                    CountyName = user.AddressInfo?.County.CountyName?? "Bilinmiyor",
                    EmergencyPerson = user.EmergencyPerson != null
                        ? $"{user.EmergencyPerson.FirstName} {user.EmergencyPerson.LastName}"
                        : "Bilinmiyor",
                    AddressDetail = user.AddressInfo?.AddressDetail ?? "Bilinmiyor",
                    AddedDate = user.AddedDate,
                    ModifiedDate = user.ModifiedDate,
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    RemainingLeave = user.RemainingLeave
                };

                employeeDTOs.Add(employeeDTO);
            }

            return employeeDTOs;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllUsersByRole(int roleID)
        {
            var users = await unitOfWork.Users.GetAllUsersByRole(roleID);

            var employeeDTOs = new List<EmployeeDTO>();

            foreach (var user in users)
            {

                var employeeDTO = new EmployeeDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    BirthDate = user.BirthDate,
                    PositionName = user.Position.PositionName,
                    HireDate = user.HireDate,
                    Salary = user.Salary,
                    GenderName = user.Gender.GenderName,
                    CompanyName = user.Company?.CompanyName ?? "Bilinmiyor",
                    CountryName = user.AddressInfo?.Country.CountryName ?? "Bilinmiyor",
                    CityName = user.AddressInfo?.City.CityName ?? "Bilinmiyor",
                    CountyName = user.AddressInfo?.County.CountyName ?? "Bilinmiyor",
                    EmergencyPerson = user.EmergencyPerson != null
                        ? $"{user.EmergencyPerson.FirstName} {user.EmergencyPerson.LastName}"
                        : "Bilinmiyor",
                    AddressDetail = user.AddressInfo?.AddressDetail ?? "Bilinmiyor",
                    AddedDate = user.AddedDate,
                    ModifiedDate = user.ModifiedDate,
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    RemainingLeave = user.RemainingLeave
                };

                employeeDTOs.Add(employeeDTO);
            }

            return employeeDTOs;
        }

        public async Task<EmployeeDTO> GetUserWithRoleByUserID(int userID)
        {
            var employeeDTO = await unitOfWork.Users.GetUserWithRoleByUserID(userID);

            if (employeeDTO == null)
            {
                return null;
            }

            return employeeDTO;
        }

    }
}
