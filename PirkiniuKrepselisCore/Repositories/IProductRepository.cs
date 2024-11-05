using PirkiniuKrepselisCore.Models;
using System.Collections.Generic;

namespace PirkiniuKrepselisCore.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        List<Product> GetAllProducts();
    }
}