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
    public class CityConfiguration: IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasOne(x => x.Country)
               .WithMany(x => x.City)
               .HasForeignKey(x => x.CountryID);


            builder.HasMany(x => x.County)
               .WithOne(x => x.City)
               .HasForeignKey(x => x.CityID);
        }
     }
}
