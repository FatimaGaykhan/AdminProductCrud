using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorella.Migrations
{
    public partial class CreatedSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1111,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1112,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1113,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1114,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1115,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1116,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1117,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1111,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1112,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDeleted", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4340), "HeaderLogo", false, "logo.png" },
                    { 2, new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4340), "Phone", false, "243571623" },
                    { 3, new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4350), "Address", false, "Ehmedli" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1111,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1112,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1113,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1114,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1115,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1116,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1117,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1111,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1112,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(250));
        }
    }
}
