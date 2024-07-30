using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace grocercy.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "Image",
                value: "fruits.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "Image",
                value: "seasonal_fruits.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "Image",
                value: "exotic_fruits.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "Image",
                value: "vegetables.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "Image",
                value: "green_vegetables.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)6,
                column: "Image",
                value: "leafy_vegetables.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)7,
                column: "Image",
                value: "salads.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)8,
                column: "Image",
                value: "dairy.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)9,
                column: "Image",
                value: "milk_curd_yogurt.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)10,
                column: "Image",
                value: "butter_cheese.jpg");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "#7fbdc7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "#e28083");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "#7fbdc7");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "Image",
                value: "fruits.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "Image",
                value: "seasonal_fruits.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "Image",
                value: "exotic_fruits.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "Image",
                value: "vegetables.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "Image",
                value: "green_vegetables.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)6,
                column: "Image",
                value: "leafy_vegetables.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)7,
                column: "Image",
                value: "salads.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)8,
                column: "Image",
                value: "dairy.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)9,
                column: "Image",
                value: "milk_curd_yogurt.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)10,
                column: "Image",
                value: "butter_cheese.png");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "#e1f1e7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "#ea978d");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "#dad1f9");
        }
    }
}
