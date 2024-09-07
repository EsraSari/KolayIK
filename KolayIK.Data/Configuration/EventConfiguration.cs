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
    public class EventConfiguration: IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(x => x.EventType)
               .WithMany(x => x.Events)
               .HasForeignKey(x => x.EventTypeID);

            builder.HasOne(x => x.Company)
              .WithMany(x => x.Events)
              .HasForeignKey(x => x.CompanyID);
        }
    }
}
