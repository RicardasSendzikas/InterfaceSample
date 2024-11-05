using System.Collections.Generic;
using PirkiniuKrepselisCore.Contracts;
using PirkiniuKrepselisCore.Models;

namespace PirkiniuKrepselisCore.Services
{
    public class ShoppingCartService : IShoppingCart
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

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}