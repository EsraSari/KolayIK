using KolayIK.Core.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasOne(c => c.Manager)
            .WithMany(u => u.ManagedCompanies)
            .HasForeignKey(c => c.ManagerID)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Approver)
                .WithMany(u => u.ApprovedCompanies)
                .HasForeignKey(c => c.ApproverID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Employees)
                .WithOne(u => u.Company)
                .HasForeignKey(c => c.CompanyID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
