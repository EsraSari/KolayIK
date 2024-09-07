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
    public class ExpenseRequestConfiguration: IEntityTypeConfiguration<ExpenseRequest>
    {
        public void Configure(EntityTypeBuilder<ExpenseRequest> builder)
        {
             builder.HasOne(er => er.User)
                    .WithMany(u => u.ExpenseRequests)
                    .HasForeignKey(er => er.UserID)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(er => er.Approver)
                   .WithMany(u => u.ApprovedExpenseReq)
                   .HasForeignKey(er => er.ApproverID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
