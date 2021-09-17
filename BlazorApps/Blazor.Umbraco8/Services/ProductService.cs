using Blazor.Umbraco8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor.Umbraco8.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductResponseModel>> GetProducts()
        {
            var content = await _httpClient.GetAsync("umbraco/api/productapi/getproducts");
            var jsonString = await content.Content.ReadAsStringAsync();
           return JsonSerializer.Deserialize<List<ProductResponseModel>>(jsonString);
        }
    }
}
