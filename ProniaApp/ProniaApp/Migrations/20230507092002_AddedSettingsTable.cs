using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2306), "Logo", false, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2321), "dark.png" },
                    { 2, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2326), "Phone", false, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2327), "+00 123 456 789" },
                    { 3, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2329), "Offer", false, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2330), "HELLO EVERYONE!25 % Off All Products" },
                    { 4, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2331), "PaymentImg", false, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2332), "1.png" },
                    { 5, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2333), "Email", false, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2333), "info@example.com" },
                    { 6, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2334), "Address", false, new DateTime(2023, 5, 7, 13, 20, 2, 385, DateTimeKind.Local).AddTicks(2335), "13, Your Address, Here" }
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
        }
    }
}
