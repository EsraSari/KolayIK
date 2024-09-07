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
    public class SeedPositions: IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasData
            (
                new Position { ID = 1, PositionName = "CEO", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 2, PositionName = "COO", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 3, PositionName = "CFO", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 4, PositionName = "CTO", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 5, PositionName = "CMO", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 6, PositionName = "Genel Müdür", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 7, PositionName = "Bölüm Müdürü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 8, PositionName = "İdari Asistan", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 9, PositionName = "Ofis Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 10, PositionName = "Sekreter", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 11, PositionName = "Muhasebeci", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 12, PositionName = "Finansal Analist", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 13, PositionName = "Mali Müşavir", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 14, PositionName = "İç Denetçi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 15, PositionName = "Vergi Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 16, PositionName = "İnsan Kaynakları Müdürü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 17, PositionName = "İK Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 18, PositionName = "Eğitim ve Gelişim Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 19, PositionName = "İşe Alım Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 20, PositionName = "Pazarlama Müdürü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 21, PositionName = "Satış Müdürü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 22, PositionName = "Dijital Pazarlama Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 23, PositionName = "Satış Temsilcisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 24, PositionName = "Müşteri İlişkileri Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 25, PositionName = "Üretim Müdürü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 26, PositionName = "Operasyon Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 27, PositionName = "Kalite Kontrol Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 28, PositionName = "Üretim Elemanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 29, PositionName = "Yazılım Geliştirici", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 30, PositionName = "Sistem Analisti", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 31, PositionName = "Veri Tabanı Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 32, PositionName = "IT Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 33, PositionName = "Teknik Destek Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 34, PositionName = "Ar-Ge Müdürü", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 35, PositionName = "Ürün Geliştirme Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 36, PositionName = "Proje Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 37, PositionName = "Hukuk Müşaviri", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 38, PositionName = "Uyum Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 39, PositionName = "Sözleşme Yöneticisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 40, PositionName = "Müşteri Hizmetleri Temsilcisi", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Position { ID = 41, PositionName = "Teknik Destek Uzmanı", Status = true, AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );
        }
    }
}
