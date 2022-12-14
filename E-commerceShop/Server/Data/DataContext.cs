using Microsoft.EntityFrameworkCore;

namespace E_commerceShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Earrings",
                    Url = "еarrings"
                },
                new Category
                {
                    Id = 4,
                    Name = "Necklaces",
                    Url = "necklaces"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Вестителят на смъртта",
                        Description = "",
                        ImageUrl = "https://assets.chitanka.info/thumb/book-cover/2b/11080.250.jpg",
                        Price = 9.99M,
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Обеци пеперуди",
                        Description = "Оригинални ръчно изработени мини обеци пеперуди, изключително леки и удобни.",
                        ImageUrl = "https://www.magazinche.com/media/18/33919.jpg",
                        Price = 10.99M,
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Колие Macrame by K.",
                        Description = "Ръчно изработено колие чрез техниката макраме.",
                        ImageUrl = "https://www.magazinche.com/media/18/33924.jpg",
                        Price = 24.99M,
                        CategoryId = 4,
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
