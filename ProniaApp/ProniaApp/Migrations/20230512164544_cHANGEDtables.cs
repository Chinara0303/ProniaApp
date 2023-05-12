using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class cHANGEDtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_AspNetUsers_AppUserId1",
                table: "ProductComments");

            migrationBuilder.DropIndex(
                name: "IX_ProductComments_AppUserId1",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "ProductComments");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "ProductComments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4943), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4945), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4952), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4957), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4959), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4960), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4892), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4894), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4902), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 5, 12, 20, 45, 44, 203, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_AppUserId",
                table: "ProductComments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_AspNetUsers_AppUserId",
                table: "ProductComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_AspNetUsers_AppUserId",
                table: "ProductComments");

            migrationBuilder.DropIndex(
                name: "IX_ProductComments_AppUserId",
                table: "ProductComments");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "ProductComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "ProductComments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2699), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2302), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 5, 12, 17, 57, 55, 203, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_AppUserId1",
                table: "ProductComments",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_AspNetUsers_AppUserId1",
                table: "ProductComments",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
