using System.Collections.Generic;
using PirkiniuKrepselisCore.Models;

namespace PirkiniuKrepselisCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}