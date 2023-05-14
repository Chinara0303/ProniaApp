using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedHeaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(831), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(834), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(837), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(840), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.InsertData(
                table: "SectionBackgroundImages",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDelete", "UpdatedDate", "Value" },
                values: new object[] { 12, new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(845), "TestimonialBg", false, new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(846), "1-1-1820x443.jpg" });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(778), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(782), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(785), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(787), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(789), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(790), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(792), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(793), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(795), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(796), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(798), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(799), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(482), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(501), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(505), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 5, 14, 3, 12, 31, 278, DateTimeKind.Local).AddTicks(507) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 12);

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
        }
    }
}
