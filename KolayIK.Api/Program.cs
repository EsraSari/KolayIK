using KolayIK.Core;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Services;
using KolayIK.Data;
using KolayIK.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json.Serialization;

namespace KolayIK.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.MaxDepth = 64; 
            });

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<KolayIKDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
            });

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IRoleService, RoleService>();
            builder.Services.AddTransient<ICompanyService, CompanyService>();
            builder.Services.AddTransient<IResumeService, ResumeService>();
            builder.Services.AddTransient<IPositionService, PositionService>();
            builder.Services.AddTransient<ILeaveTypeService, LeaveTypeService>();
            builder.Services.AddTransient<IStateService, StateService>();
            builder.Services.AddTransient<IExperienceService, ExperienceService>();
            builder.Services.AddTransient<ICertificateService, CertificateService>();
            builder.Services.AddTransient<IEducationService, EducationService>();
            builder.Services.AddTransient<ILeaveRequestService, LeaveRequestService>();
            builder.Services.AddTransient<IExpenseRequestService, ExpenseRequestService>();
            builder.Services.AddTransient<IEventService, EventService>();
            builder.Services.AddTransient<ICityService, CityService>();
            builder.Services.AddTransient<ICountryService, CountryService>();
            builder.Services.AddTransient<ICountyService, CountyService>();
            builder.Services.AddTransient<IAddressInfoService, AddressService>();
            builder.Services.AddTransient<IGenderService, GenderService>();
            builder.Services.AddTransient<IEmergencyPersonService, EmergencyPersonService>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<KolayIKDBContext>()
            .AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "IdentityManagement";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.SlidingExpiration = true;
            });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowSpecificOrigins");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }

}
