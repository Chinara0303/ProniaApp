using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedSeedingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4907), new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4908) });

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
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4657), "Logo", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4668), "dark.png" },
                    { 2, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4673), "Phone", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4674), "+00 123 456 789" },
                    { 3, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4678), "Offer", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4679), "HELLO EVERYONE!25 % Off All Products" },
                    { 4, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4680), "PaymentImg", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4681), "1.png" },
                    { 5, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4682), "Email", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4683), "info@example.com" },
                    { 6, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4684), "Address", false, new DateTime(2023, 5, 8, 10, 25, 51, 249, DateTimeKind.Local).AddTicks(4685), "13, Your Address, Here" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6203), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6205), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6208), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6214), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6217), new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6218) });
        }
    }
}
