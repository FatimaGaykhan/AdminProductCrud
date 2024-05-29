using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorella.Migrations
{
    public partial class CreatedExpertTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "CreatedDate", "FullName", "Image", "Position", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8940), "Fatima Gaykhanova", "h3-team-img-1.png", "Florist", false },
                    { 2, new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8950), "Inji Gaykhanova", "h3-team-img-2.png", "Manager", false },
                    { 3, new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8950), "Fidan Gaykhanova", "h3-team-img-3.png", "Florist", false },
                    { 4, new DateTime(2024, 5, 14, 22, 31, 33, 787, DateTimeKind.Local).AddTicks(8950), "Gunel Hasanova", "h3-team-img-4.png", "Florist", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 20, 58, 29, 351, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 20, 58, 29, 351, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 20, 58, 29, 351, DateTimeKind.Local).AddTicks(90));
        }
    }
}
