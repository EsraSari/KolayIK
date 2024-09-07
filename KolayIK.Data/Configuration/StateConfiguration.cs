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
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {

            builder.HasMany(x => x.LeaveRequests)
                   .WithOne(x => x.State)
                   .HasForeignKey(x => x.StateID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ExpenseRequests)
                   .WithOne(x => x.State)
                   .HasForeignKey(x => x.StateID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Companies)
                   .WithOne(x => x.ApprovalStatus)
                   .HasForeignKey(x => x.ApprovalStatusID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
