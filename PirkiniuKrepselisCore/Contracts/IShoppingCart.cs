using PirkiniuKrepselisCore.Models;
using System.Collections.Generic;

namespace PirkiniuKrepselisCore.Contracts
{
    public interface IShoppingCart
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        List<Product> GetProducts();
    }
}