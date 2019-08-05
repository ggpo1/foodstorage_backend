using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int productID);
        Task<List<Product>> GetProductTypeProducts(int productTypeID);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
    }
}
