using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedProdutsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Product_ProductId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Colors_ColorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Product_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Product_ProductId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Product_ProductId",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ColorId",
                table: "Products",
                newName: "IX_Products_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(750), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(755), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(758), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(762), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(766), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(770), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(773), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(777), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(781), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(784), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(659), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(667), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(670), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(679), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(686), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(694), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(697), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(413), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 5, 9, 11, 47, 48, 649, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Products_ProductId",
                table: "Comment",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Products_ProductId",
                table: "ProductSizes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Products_ProductId",
                table: "ProductTags",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Products_ProductId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Products_ProductId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Products_ProductId",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ColorId",
                table: "Product",
                newName: "IX_Product_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7514), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7517), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(6991), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7013), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7139), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7141), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7143), new DateTime(2023, 5, 8, 15, 9, 5, 275, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Product_ProductId",
                table: "Comment",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Colors_ColorId",
                table: "Product",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Product_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Product_ProductId",
                table: "ProductSizes",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Product_ProductId",
                table: "ProductTags",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
