// <auto-generated />
using E_commerceShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_commerceShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Earrings",
                            Url = "еarrings"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Necklaces",
                            Url = "necklaces"
                        });
                });

            modelBuilder.Entity("E_commerceShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatalogNumber")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "",
                            CatalogNumber = 0,
                            CategoryId = 1,
                            Description = "",
                            ImageUrl = "https://assets.chitanka.info/thumb/book-cover/2b/11080.250.jpg",
                            Price = 9.99m,
                            Title = "Вестителят на смъртта"
                        },
                        new
                        {
                            Id = 2,
                            Author = "",
                            CatalogNumber = 0,
                            CategoryId = 3,
                            Description = "Оригинални ръчно изработени мини обеци пеперуди, изключително леки и удобни.",
                            ImageUrl = "https://www.magazinche.com/media/18/33919.jpg",
                            Price = 10.99m,
                            Title = "Обеци пеперуди"
                        },
                        new
                        {
                            Id = 3,
                            Author = "",
                            CatalogNumber = 0,
                            CategoryId = 4,
                            Description = "Ръчно изработено колие чрез техниката макраме.",
                            ImageUrl = "https://www.magazinche.com/media/18/33924.jpg",
                            Price = 24.99m,
                            Title = "Колие Macrame by K."
                        });
                });

            modelBuilder.Entity("E_commerceShop.Shared.Product", b =>
                {
                    b.HasOne("E_commerceShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
