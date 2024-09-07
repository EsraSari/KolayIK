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
    public class SeedStates: IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasData
                (
                    new State { ID = 1, StateName = "Onay Bekliyor", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new State { ID = 2, StateName = "Onaylandı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new State { ID = 3, StateName = "Reddedildi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
