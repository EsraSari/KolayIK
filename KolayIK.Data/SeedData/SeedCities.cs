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
    public class SeedCities: IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData
                 (
                    new City { ID = 1, CityName = "Adana", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 2, CityName = "Adıyaman", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 3, CityName = "Afyonkarahisar", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 4, CityName = "Ağrı", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 5, CityName = "Amasya", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 6, CityName = "Ankara", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 7, CityName = "Antalya", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 8, CityName = "Artvin", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 9, CityName = "Aydın", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 10, CityName = "Balıkesir", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 11, CityName = "Bilecik", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 12, CityName = "Bingöl", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 13, CityName = "Bitlis", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 14, CityName = "Bolu", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 15, CityName = "Burdur", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 16, CityName = "Bursa", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 17, CityName = "Çanakkale", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 18, CityName = "Çankırı", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 19, CityName = "Çorum", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 20, CityName = "Denizli", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 21, CityName = "Diyarbakır", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 22, CityName = "Edirne", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 23, CityName = "Elazığ", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 24, CityName = "Erzincan", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 25, CityName = "Erzurum", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 26, CityName = "Eskişehir", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 27, CityName = "Gaziantep", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 28, CityName = "Giresun", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 29, CityName = "Gümüşhane", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 30, CityName = "Hakkâri", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 31, CityName = "Hatay", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 32, CityName = "Isparta", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 33, CityName = "Mersin", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 34, CityName = "İstanbul", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 35, CityName = "İzmir", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 36, CityName = "Kars", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 37, CityName = "Kastamonu", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 38, CityName = "Kayseri", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 39, CityName = "Kırklareli", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 40, CityName = "Kırşehir", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 41, CityName = "Kocaeli", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 42, CityName = "Konya", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 43, CityName = "Kütahya", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 44, CityName = "Malatya", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 45, CityName = "Manisa", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 46, CityName = "Kahramanmaraş", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 47, CityName = "Mardin", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 48, CityName = "Muğla", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 49, CityName = "Muş", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 50, CityName = "Nevşehir", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 51, CityName = "Niğde", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 52, CityName = "Ordu", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 53, CityName = "Rize", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 54, CityName = "Sakarya", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 55, CityName = "Samsun", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 56, CityName = "Siirt", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 57, CityName = "Sinop", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 58, CityName = "Sivas", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 59, CityName = "Tekirdağ", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 60, CityName = "Tokat", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 61, CityName = "Trabzon", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 62, CityName = "Tunceli", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 63, CityName = "Şanlıurfa", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 64, CityName = "Uşak", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 65, CityName = "Van", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 66, CityName = "Yozgat", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 67, CityName = "Zonguldak", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 68, CityName = "Aksaray", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 69, CityName = "Bayburt", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 70, CityName = "Karaman", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 71, CityName = "Kırıkkale", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 72, CityName = "Batman", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 73, CityName = "Şırnak", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 74, CityName = "Bartın", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 75, CityName = "Ardahan", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 76, CityName = "Iğdır", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 77, CityName = "Yalova", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 78, CityName = "Karabük", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 79, CityName = "Kilis", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 80, CityName = "Osmaniye", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                    new City { ID = 81, CityName = "Düzce", CountryID = 1, Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                 );
        }
    }
}
