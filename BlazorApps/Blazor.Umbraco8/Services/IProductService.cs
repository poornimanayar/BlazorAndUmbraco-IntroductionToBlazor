using Blazor.Umbraco8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Umbraco8.Services
{
    public interface IProductService
    {
        Task<List<ProductResponseModel>> GetProducts();
    }
}
