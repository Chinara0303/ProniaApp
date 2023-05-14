using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class ChangedColumntype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId1",
                table: "BlogComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogComments_AppUserId1",
                table: "BlogComments");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "BlogComments");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "BlogComments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4513), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4519), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4523), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4525), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4424), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4426), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4472), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4131), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4147), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4154), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4157), new DateTime(2023, 5, 13, 10, 21, 57, 755, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_AppUserId",
                table: "BlogComments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId",
                table: "BlogComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId",
                table: "BlogComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogComments_AppUserId",
                table: "BlogComments");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "BlogComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "BlogComments",
                type: "nvarchar(450)",
                nullable: true);

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
                name: "IX_BlogComments_AppUserId1",
                table: "BlogComments",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_AspNetUsers_AppUserId1",
                table: "BlogComments",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
