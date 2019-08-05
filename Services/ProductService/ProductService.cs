using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;

namespace FoodStorage_Backend.Services.ProductService
{
    public class ProductService : IProductService
    {
        public Task<Product> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(int productID)
        {
            return Task.Run(() => MyDb.db.Products.FirstOrDefault(elem => elem.ProductID == productID));
        }

        public Task<List<Product>> GetProducts()
        {
            return Task.Run(() => MyDb.db.Products.ToList());
        }

        public Task<List<Product>> GetProductTypeProducts(int productTypeID)
        {
            return Task.Run(() => MyDb.db.Products.Where(elem => elem.ProductTypeID == productTypeID).ToList());
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
