using KolayIK.Core.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolayIK.Data.SeedData
{
    public class SeedCounties : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.HasData
            (
                new County { ID = 1, CountyName = "Kağıthane", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 2, CountyName = "Şişli", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 3, CountyName = "Beşiktaş", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 4, CountyName = "Beyoğlu", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 5, CountyName = "Kadıköy", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 6, CountyName = "Üsküdar", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 7, CountyName = "Fatih", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 8, CountyName = "Bakırköy", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 9, CountyName = "Maltepe", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 10, CountyName = "Ataşehir", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 11, CountyName = "Büyükçekmece", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 12, CountyName = "Sarıyer", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 13, CountyName = "Kartal", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 14, CountyName = "Şile", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 15, CountyName = "Çatalca", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 16, CountyName = "Adalar", CityID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 17, CountyName = "Altındağ", CityID = 2, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 18, CountyName = "Ayaş", CityID = 2, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new County { ID = 19, CountyName = "Bala", CityID = 2, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }

            );
        }
    }
}
