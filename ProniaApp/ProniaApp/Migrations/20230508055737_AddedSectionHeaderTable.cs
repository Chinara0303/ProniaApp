using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedSectionHeaderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "SectionHeaders",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6190), "ProductTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6199), "OUR PRODUCTS" },
                    { 2, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6203), "NewProductTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6203), "NEW PRODUCTS" },
                    { 3, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6205), "NewProductDesc", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6205), "Contrary to popular belief, Lorem Ipsum is not simply random text.It has roots in a piece of classical Latin literature" },
                    { 4, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6206), "TestimonialTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6206), "WHAT SAY CLIENT" },
                    { 5, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6207), "TestimonialDesc", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6208), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature" },
                    { 6, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6208), "LatestBlogTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6209), "LATEST BLOG" },
                    { 7, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6210), "LatestBlogDesc", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6210), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature" },
                    { 8, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6211), "LatestBlogTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6211), "LATEST BLOG" },
                    { 9, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6212), "OurStoryTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6213), "<h2 class='about-title'>Our<span> Story</span></h2>" },
                    { 10, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6214), "OurStoryDesc", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6214), "Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis" },
                    { 11, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6215), "CounterTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6215), "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Sed ut perspiciatis" },
                    { 12, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6216), "OurTeamTitle", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6217), "OUR TEAM" },
                    { 13, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6217), "OurTeamDesc", false, new DateTime(2023, 5, 8, 9, 57, 37, 209, DateTimeKind.Local).AddTicks(6218), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13);

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
    }
}
