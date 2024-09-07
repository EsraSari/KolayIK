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
    public class AddressInfoConfiguration : IEntityTypeConfiguration<AddressInfo>
    {
        public void Configure(EntityTypeBuilder<AddressInfo> builder)
        {
            builder.HasOne(x => x.User)
             .WithOne(x => x.AddressInfo)
             .HasForeignKey<AddressInfo>(x => x.UserID)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.City)
                .WithMany(x => x.AddressInfo)
                .HasForeignKey(x => x.CityID);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.AddressInfo)
                .HasForeignKey(x => x.CountryID);

            builder.HasOne(x => x.County)
                .WithMany(x => x.AddressInfo)
                .HasForeignKey(x => x.CountyID);
        }
    }
}
