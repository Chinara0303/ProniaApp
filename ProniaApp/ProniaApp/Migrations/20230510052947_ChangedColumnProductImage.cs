using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class ChangedColumnProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHover",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHover",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "ProductImages");

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8698), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8638), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8651), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8083), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 5, 9, 14, 53, 13, 656, DateTimeKind.Local).AddTicks(8089) });
        }
    }
}
