using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedSeedingSectionbackgroundTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1935), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1938), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1939), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1941), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1942), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1945), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1946), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.InsertData(
                table: "SectionBackgroundImages",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 9, new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2048), "CartIntroBg", false, new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2048), "1 - 1 - 370x500.jpg" },
                    { 10, new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2050), "AccountIntroBg", false, new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2050), "1 - 1 - 370x500.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1880), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1882), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1884), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1885), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1887), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1890), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1891), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1895), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1607), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(1611) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8697), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8702), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8714), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8449), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8466), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8468), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8470), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8472) });
        }
    }
}
