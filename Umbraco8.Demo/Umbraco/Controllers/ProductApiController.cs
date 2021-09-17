
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.PublishedModels;
using Umbraco.Web.WebApi;

namespace Umbraco.Controllers
{
 
    public class ProductApiController : UmbracoApiController
    {
        // GET: ProductApi

        [HttpGet]
        public List<ProductResponseModel> GetProducts()
        {
            var products = Umbraco.ContentAtXPath("//home/products/product").OfType<Product>();

            var productResponse = new List<ProductResponseModel>();

            foreach(var product in products)
            {
                productResponse.Add(new ProductResponseModel
                {
                    ProductName = product.ProductName,
                    ProductSku = product.Sku
                });
            }

            return productResponse;
        }
    }
}