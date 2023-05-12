using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedCommentsAndContactables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductComments_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductComments_Products_ProductId",
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
                name: "IX_BlogComments_AppUserId1",
                table: "BlogComments",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogId",
                table: "BlogComments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_AppUserId1",
                table: "ProductComments",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_ProductId",
                table: "ProductComments",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ProductComments");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Products_ProductId",
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
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7461), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7465), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7472), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7305), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7307), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6939), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6944), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6946), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6949), new DateTime(2023, 5, 12, 15, 39, 33, 690, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserId1",
                table: "Comment",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_BlogId",
                table: "Comment",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");
        }
    }
}
