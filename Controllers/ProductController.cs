using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.ProductService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
    {
        IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        #region Get data methods
        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            return await service.GetProducts();
        }

        [HttpGet]
        [Route("getproductbyid")]
        public async Task<Product> GetProdutByID(int productID)
        {
            return await service.GetProduct(productID);
        }

        [HttpGet]
        [Route("getproducttypeproducts")]
        public async Task<List<Product>> GetProdutTypeProducts(int productTypeID)
        {
            return await service.GetProductTypeProducts(productTypeID);
        }

        #endregion
        #region Post data methods
        [HttpPost]
        public async Task<Product> AddProduct([FromBody]Product product)
        {
            return await service.AddProduct(product);
        }
        // TODO: UPDATE METHOD
        #endregion
    }
}
