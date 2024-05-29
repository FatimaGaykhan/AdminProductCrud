using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorella.Migrations
{
    public partial class CreatedSocialsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1111,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1112,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1113,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1114,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1115,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1116,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1117,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1111,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1112,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedDate", "Icon", "Name", "SoftDeleted", "URL" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8770), "zmdi zmdi-youtube", "Instagram", false, "https://www.youtube.com" },
                    { 2, new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8770), "zmdi zmdi-pinterest", "Pinterest", false, "https://www.pinterest.com" },
                    { 3, new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8770), "zmdi zmdi-linkedin", "LinkedIn", false, "https://www.linkedin.com" },
                    { 4, new DateTime(2024, 5, 21, 22, 45, 35, 988, DateTimeKind.Local).AddTicks(8770), "zmdi zmdi-amazon", "Amazon", false, "https://www.amazon.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socials");

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

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4350));
        }
    }
}
