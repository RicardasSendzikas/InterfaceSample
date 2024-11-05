using System;
using PirkiniuKrepselisCore.Models;
using PirkiniuKrepselisCore.Services;

namespace PirkiniuKrepselis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sukuriame pirkinių krepšelį
            var cart = new ShoppingCartService(); // Naudojamas ShoppingCartService
            cart.AddProduct(new Product("Obuolys", 1.50m));
            cart.AddProduct(new Product("Bananas", 0.80m));
            cart.AddProduct(new Product("Duona", 2.50m));
            cart.AddProduct(new Product("Sviestas", 1.80m));

            Console.WriteLine("Prekės krepšelyje:");
            foreach (var product in cart.GetProducts())
            {
                Console.WriteLine($"{product.Name}: {product.Price} EUR");
            }

            // Pašaliname produktą
            cart.RemoveProduct(new Product("Banana", 0.80m));

            Console.WriteLine("\nPo banano pašalinimo:");
            foreach (var product in cart.GetProducts())
            {
                Console.WriteLine($"{product.Name}: {product.Price} EUR");
            }
        }
    }
}