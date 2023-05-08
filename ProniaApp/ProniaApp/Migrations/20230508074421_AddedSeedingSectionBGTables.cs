using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedSeedingSectionBGTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "SectionBackgroundImages",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8742), "SliderBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8744), "1-1.jpg" },
                    { 2, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8746), "BrandBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8747), "1-1170x300.jpg" },
                    { 3, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8748), "FooterBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8749), "1-1920x465.jpg" },
                    { 4, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8750), "ShopIntroBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8750), "1 - 1 - 1919x388.jpg" },
                    { 5, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8752), "BlogIntroBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8752), "1 - 1 - 1919x388.jpg" },
                    { 6, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8753), "AboutIntroBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8754), "1 - 1 - 1919x388.jpg" },
                    { 7, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8755), "ContactIntroBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8755), "1 - 1 - 1919x388.jpg" },
                    { 8, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8756), "ContactInfoBg", false, new DateTime(2023, 5, 8, 11, 44, 20, 264, DateTimeKind.Local).AddTicks(8757), "1 - 1 - 370x500.jpg" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4892), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4901), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4911), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4914), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4916), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.InsertData(
                table: "SectionHeaders",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[] { 8, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4907), "LatestBlogTitle", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4908), "LATEST BLOG" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4685) });
        }
    }
}
