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
    public class SeedCompanies : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
                (
                    new Company { ID = 1, CompanyName= "ABC Company", Phone = "2122222222", ManagerID = 2, ApprovalStatusID = 2, ApproverID = 1, ApprovalDate = DateTime.Now ,Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
