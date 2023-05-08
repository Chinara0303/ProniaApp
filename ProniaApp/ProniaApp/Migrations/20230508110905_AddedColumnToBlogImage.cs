using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedColumnToBlogImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "BlogImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7514), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7517), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(6991), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7013), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7139), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7141), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7143), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7143) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "BlogImages");

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

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2048), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 5, 8, 11, 47, 44, 731, DateTimeKind.Local).AddTicks(2050) });

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
    }
}
