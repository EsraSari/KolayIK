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
    public class ResumeConfiguration: IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasOne(r => r.User)
            .WithOne(u => u.Resume)
            .HasForeignKey<Resume>(r => r.UserID);

            builder.HasMany(x => x.WorkExperiences)
               .WithOne(x => x.Resume)
               .HasForeignKey(x => x.ResumeID)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Educations)
               .WithOne(x => x.Resume)
               .HasForeignKey(x => x.ResumeID)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Certificates)
               .WithOne(x => x.Resume)
               .HasForeignKey(x => x.ResumeID)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
