using E_commerceShop.Shared;
using System.Net.Http.Json;

namespace E_commerceShop.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;
        public ProductService(HttpClient http)
        {
            this.http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await this.http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts()
        {
            var result = await this.http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
            {
                this.Products = result.Data;
            }
        }
    }
}
