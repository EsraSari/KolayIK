using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Data.Configuration;
using KolayIK.Data.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data
{
    public class KolayIKDBContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public KolayIKDBContext(DbContextOptions<KolayIKDBContext> options) : base(options)
        {

        }


        public DbSet<AddressInfo> AddressInfos { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EmergencyPerson> EmergencyPersons { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<ExpenseRequest> ExpenseRequests { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AddressInfoConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmergencyPersonConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseRequestConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new LeaveRequestConfiguration());
            modelBuilder.ApplyConfiguration(new ResumeConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new SeedCities());
            modelBuilder.ApplyConfiguration(new SeedCounties());
            modelBuilder.ApplyConfiguration(new SeedCountries());
            modelBuilder.ApplyConfiguration(new SeedEvents());
            modelBuilder.ApplyConfiguration(new SeedEventTypes());
            modelBuilder.ApplyConfiguration(new SeedExperiences());
            modelBuilder.ApplyConfiguration(new SeedGenders());
            modelBuilder.ApplyConfiguration(new SeedLeaveTypes());
            modelBuilder.ApplyConfiguration(new SeedPositions());
            modelBuilder.ApplyConfiguration(new SeedResumes());
            modelBuilder.ApplyConfiguration(new SeedStates());
            modelBuilder.ApplyConfiguration(new SeedRoles());



            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
            });
        }
    }
}
