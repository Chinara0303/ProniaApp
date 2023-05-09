using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class changedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ProudctId",
                table: "ProductCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProudctId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
