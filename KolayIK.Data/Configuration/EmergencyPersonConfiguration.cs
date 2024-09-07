using KolayIK.Core.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Configuration
{
    public class EmergencyPersonConfiguration : IEntityTypeConfiguration<EmergencyPerson>
    {
        public void Configure(EntityTypeBuilder<EmergencyPerson> builder)
        {
               builder.HasOne(e => e.Employee)
                      .WithOne(u => u.EmergencyPerson)
                      .HasForeignKey<EmergencyPerson>(e => e.EmployeeID)
                      .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
