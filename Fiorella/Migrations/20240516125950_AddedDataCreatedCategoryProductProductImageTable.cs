using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorella.Migrations
{
    public partial class AddedDataCreatedCategoryProductProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1111, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180), "POPULAR", false },
                    { 1112, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180), "WINTER", false },
                    { 1113, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180), "VARIOUS", false },
                    { 1114, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(180), "EXOTIC", false },
                    { 1115, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(190), "GREENS", false },
                    { 1116, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(190), "CACTUSES", false },
                    { 1117, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(190), "ROSES", false }
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "SoftDeleted" },
                values: new object[,]
                {
                    { 1006, 1113, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(230), "Desc6", "Product6", 20m, false },
                    { 1007, 1114, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(230), "Desc7", "Product7", 7000m, false },
                    { 1008, 1114, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240), "Desc8", "Product8", 2300m, false },
                    { 1009, 1115, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240), "Desc9", "Product9", 240m, false },
                    { 1010, 1115, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240), "Desc10", "Product10", 750m, false },
                    { 1111, 1116, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(240), "Desc11", "Product11", 300m, false },
                    { 1112, 1116, new DateTime(2024, 5, 16, 16, 59, 50, 324, DateTimeKind.Local).AddTicks(250), "Desc12", "Product12", 450m, false }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "IsMain", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1000, true, "shop-14-img.jpg", 1006 },
                    { 1002, false, "shop-7-img.jpg", 1006 },
                    { 1003, true, "shop-10-img.jpg", 1007 },
                    { 1004, false, "shop-10-img.jpg", 1007 },
                    { 1005, true, "shop-9-img.jpg", 1008 },
                    { 1006, false, "shop-9-img.jpg", 1008 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 17, 50, 17, 412, DateTimeKind.Local).AddTicks(2630));
        }
    }
}
