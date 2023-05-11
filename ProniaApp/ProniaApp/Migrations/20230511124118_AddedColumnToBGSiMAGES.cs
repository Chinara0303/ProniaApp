using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedColumnToBGSiMAGES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8445), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8448), "1-1-1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8449), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8449), "1-1-1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8451), "1-1-1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8452), "1-1-1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8453), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8453), "1-1-370x500.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8454), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8454), "1-1-370x500.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8455), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8456), "1-1-370x500.jpg" });

            migrationBuilder.InsertData(
                table: "SectionBackgroundImages",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[] { 11, new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8457), "SingleProductIntroBg", false, new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8457), "1-1-370x500.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8409), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8412), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8413), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8416), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8417), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8418), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8421), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8422), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8236), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8253), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8255), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8258), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 5, 11, 16, 41, 17, 720, DateTimeKind.Local).AddTicks(8259) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1897), "1 - 1 - 1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1899), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1899), "1 - 1 - 1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1901), "1 - 1 - 1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1903), "1 - 1 - 1919x388.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1904), "1 - 1 - 370x500.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1906), "1 - 1 - 370x500.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1907), "1 - 1 - 370x500.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1765), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1772), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1846), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1850), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1414), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1421), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1423) });
        }
    }
}
