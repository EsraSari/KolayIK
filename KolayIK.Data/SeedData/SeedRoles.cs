using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.SeedData
{
    public class SeedRoles : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData
               (
                  new AppRole { Id = 1, Name = "Manager", NormalizedName = "MANAGER"},
                  new AppRole { Id = 2, Name= "Admin", NormalizedName = "ADMIN"},
                  new AppRole { Id = 3, Name= "Employee", NormalizedName = "EMPLOYEE"}
               );
        }
    }


}
