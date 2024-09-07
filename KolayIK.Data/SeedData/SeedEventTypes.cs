using KolayIK.Core.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.SeedData
{
    public class SeedEventTypes: IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            builder.HasData
                 (
                     new EventType { ID = 1, EventTypeName = "Resmi Tatil", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new EventType { ID = 2, EventTypeName = "Dini Bayram", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
