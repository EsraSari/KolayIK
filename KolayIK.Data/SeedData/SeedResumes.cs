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
    public class SeedResumes: IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            //builder.HasData
            //    (
            //        new Resume { ID = 1, EmployeeID = "1", Summary = "Özgeçmişe dair bilgiler", Skills = {"Skill1", "Skill2"}, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            //    );
        }
    }
}
