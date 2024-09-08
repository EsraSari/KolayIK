using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KolayIK.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondKolayIK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AddressInfos_UserID",
                table: "AddressInfos");

            migrationBuilder.DropColumn(
                name: "AddressInfoID",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6785), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7041), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7093), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7129), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7139), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7147), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7198), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8134), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8136), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8143), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8145), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8158), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8161), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8163), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8165), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8167), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8301), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8303), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8312), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8320), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8798), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8928), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8935), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9041), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9052), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9054), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9061), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9184), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9399), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 9, 8, 16, 11, 17, 295, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfos_UserID",
                table: "AddressInfos",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AddressInfos_UserID",
                table: "AddressInfos");

            migrationBuilder.AddColumn<int>(
                name: "AddressInfoID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3887), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3903), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3956), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3968), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3971), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3975), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3979), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3994), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4002), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4087), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4109), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4128), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4135), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4156), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4204), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4212), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4219), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4223), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4227), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4237), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4241), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4252), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4256), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4274), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4277), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4281), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4721), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6348), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6356), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6363), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6721), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6567), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7327), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7349), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7353), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7356), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7364), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7367), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7371), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7375), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7415), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7422), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7432), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfos_UserID",
                table: "AddressInfos",
                column: "UserID",
                unique: true);
        }
    }
}
