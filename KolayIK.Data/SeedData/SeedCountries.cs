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
    public class SeedCountries: IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData
                 (
                     new Country { ID = 1, CountryName = "Türkiye", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 2, CountryName = "Almanya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 3, CountryName = "Fransa", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 4, CountryName = "İngiltere", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 5, CountryName = "İtalya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 6, CountryName = "İspanya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 7, CountryName = "Türkiye", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 8, CountryName = "Ukrayna", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 9, CountryName = "Polonya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 10, CountryName = "Romanya", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Country { ID = 11, CountryName = "Hollanda", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
