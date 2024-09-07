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
    public class SeedAddressInfo : IEntityTypeConfiguration<AddressInfo>
    {
        public void Configure(EntityTypeBuilder<AddressInfo> builder)
        {
            builder.HasData
                 (
                    new AddressInfo { ID = 1, UserID = 1, CountryID = 1, CityID = 34, CountyID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new AddressInfo { ID = 2, UserID = 2, CountryID = 1, CityID = 34, CountyID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
