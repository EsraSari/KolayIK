using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(x => x.Position)
             .WithMany(x => x.Users)
             .HasForeignKey(x => x.PositionID)
             .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Gender)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.GenderID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
