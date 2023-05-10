using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class DeleteColumnProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoverImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Products");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1899), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 5, 10, 12, 5, 8, 715, DateTimeKind.Local).AddTicks(1907) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HoverImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1865), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1867), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1869), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1873), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1874), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1876), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1833), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1836), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1839), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1844), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1579), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1595), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1597), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 5, 10, 9, 29, 46, 483, DateTimeKind.Local).AddTicks(1599) });
        }
    }
}
