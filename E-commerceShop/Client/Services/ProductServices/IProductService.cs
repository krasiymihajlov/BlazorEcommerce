using E_commerceShop.Shared;

namespace E_commerceShop.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
