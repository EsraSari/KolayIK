using KolayIK.Core.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.SeedData
{
    public class SeedLeaveTypes: IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData
                 (
                     new LeaveType { ID = 1, LeaveTypeName = "Mazeretsiz İzin", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new LeaveType { ID = 2, LeaveTypeName = "Yıllık İzin", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new LeaveType { ID = 3, LeaveTypeName = "Doğum İzni", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new LeaveType { ID = 4, LeaveTypeName = "Rapor", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
