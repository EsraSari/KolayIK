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
    public class SeedGenders: IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData
                 (
                     new Gender { ID = 1, GenderName = "Kadın", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                     new Gender { ID = 2, GenderName = "Erkek", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
