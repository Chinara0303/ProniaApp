using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedCartTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartProducts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1096), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1098), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1106), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1111), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1045), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1057), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1060), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1063), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(753), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(773), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(778), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(780), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(782), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(783), new DateTime(2023, 5, 13, 11, 48, 10, 25, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_CartId",
                table: "CartProducts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProducts");

            migrationBuilder.DropTable(
                name: "Carts");

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
        }
    }
}
