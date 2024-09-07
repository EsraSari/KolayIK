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
    public class SeedExperiences: IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            //builder.HasData
            //    (
            //        new Experience { ID = 1, CompanyName = "İstanbul Medipol", StartDate = new DateTime(2020,01,01), EndDate = new DateTime(2022,01,01), PositionID = 1, ResumeID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            //    );
        }
    }
}
