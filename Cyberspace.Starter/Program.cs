using System;
using System.Collections.Generic;

namespace Cyberspace.Starter
{
    public class Animal
    {
        public string Name { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var products = new List<Product>()
            {
                new Product() { Name = "Quaker Oats", Quantity = 23},
                new Product() { Name = "Fruit 'n' Fibre", Quantity = 30},
                new Product() { Name = "Kotex", Quantity = 45},
                new Product() { Name = "Maryland Cookies", Quantity = 57},
                new Product() { Name = "Cadbury Fingers", Quantity = 20},
                new Product() { Name = "Jacob's Water", Quantity = 62},
                new Product() {Name = "Golden Penny Spaghetti", Quantity = 12},
                new Product() { Name = "Home County Ice Cream", Quantity = 105},
                new Product() { Name = "Head and Shoulders", Quantity = 33},
                new Product() {Name = "Lipton Tea", Quantity = 63}
            };
            products.Sort(new SortProducts());

            //products.ForEach(p => Console.WriteLine(p.ToString()));
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            
        }
    }
}

