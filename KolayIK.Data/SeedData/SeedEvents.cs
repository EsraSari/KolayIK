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
    public class SeedEvents: IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData
                 (
                     new Event { ID = 1, EventName = "Yılbaşı Günü", EventTypeID = 1, StartDate = new DateTime(2025, 01, 01), Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Event { ID = 2, EventName = "23 Nisan Ulusal Egemenlik ve Çocuk Bayramı", EventTypeID = 1, StartDate = new DateTime(2025, 04, 23), Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Event { ID = 3, EventName = "1 Mayıs – Emek ve Dayanışma Günü", EventTypeID = 1, StartDate = new DateTime(2025, 05, 01), Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Event { ID = 4, EventName = "30 Ağustos – Zafer Bayramı", EventTypeID = 1, StartDate = new DateTime(2025, 08, 30), Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Event { ID = 5, EventName = "29 Ekim – Cumhuriyet Bayramı", EventTypeID = 1, StartDate = new DateTime(2025, 10, 29), Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
