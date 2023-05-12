using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaApp.Migrations
{
    public partial class AddedColumnToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemember",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemember",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "SectionBackgroundImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3127), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "SectionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3077), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 5, 12, 13, 11, 6, 439, DateTimeKind.Local).AddTicks(2757) });
        }
    }
}
