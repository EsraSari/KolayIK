using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.SeedData
{
    public class SeedEmergencyPerson : IEntityTypeConfiguration<EmergencyPerson>
    {
        public void Configure(EntityTypeBuilder<EmergencyPerson> builder)
        {
            builder.HasData
                (
                   new EmergencyPerson { ID = 1, FirstName = "TestAdminEmergencyPerson", LastName = "TestAdminEmergencyPerson", Phone = "05555555555", Email = "testep@testep.com", EmployeeID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                   new EmergencyPerson { ID = 2, FirstName = "TestManagerEP", LastName = "TestManagerEP", Phone = "05555555555", Email = "testmngep@testep.com", EmployeeID = 2, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
