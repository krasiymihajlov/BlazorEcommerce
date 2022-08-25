using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceShop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CatalogNumber", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "", 0, "", "https://assets.chitanka.info/thumb/book-cover/2b/11080.250.jpg", 9.99m, "Вестителят на смъртта" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CatalogNumber", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "", 0, "Оригинални ръчно изработени мини обеци пеперуди, изключително леки и удобни.", "https://www.magazinche.com/media/18/33919.jpg", 10.99m, "Обеци пеперуди" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CatalogNumber", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "", 0, "Ръчно изработено колие чрез техниката макраме.", "https://www.magazinche.com/media/18/33924.jpg", 24.99m, "Колие Macrame by K." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
