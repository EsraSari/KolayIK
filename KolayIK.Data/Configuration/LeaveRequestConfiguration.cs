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
    public class LeaveRequestConfiguration: IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasOne(er => er.User)
                    .WithMany(u => u.LeaveRequests)
                    .HasForeignKey(er => er.UserID)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(er => er.Approver)
                   .WithMany(u => u.ApprovedLeaveReq)
                   .HasForeignKey(er => er.ApproverID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.LeaveType)
                 .WithMany(x => x.LeaveRequests)
                 .HasForeignKey(x => x.LeaveTypeID);

        }
    }
}
