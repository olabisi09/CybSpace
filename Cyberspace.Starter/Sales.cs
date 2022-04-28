using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Sales
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public static List<Sales> GetSales()
        {
            return new List<Sales>
            {
                new Sales() { Id = 2, CategoryName = "Stationery"},
                new Sales() { Id = 6, CategoryName = "Fruits"},
                new Sales() { Id = 8, CategoryName = "Drinks"},
                new Sales() { Id = 10, CategoryName = "Beverages"},
                new Sales(){ Id = 12, CategoryName = "Flour"}
            };
        }
    }

    public class Item
    {
        public int RollNumber { get; set; }
        public int SalesId { get; set; }
        public string ItemName { get; set; }
        public double Amount { get; set; }

        public static List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item() { RollNumber = 10, SalesId = 2, ItemName = "Books", Amount = 500},
                new Item() { RollNumber = 20, SalesId = 8, ItemName = "Bottled Fanta", Amount = 150},
                new Item() { RollNumber = 30, SalesId = 6, ItemName = "Apple", Amount = 200},
                new Item() { RollNumber = 40, SalesId = 12, ItemName = "Bread", Amount = 650},
                new Item() { RollNumber = 60, SalesId = 10, ItemName = "Milo", Amount = 1000},
                new Item() { RollNumber = 80, SalesId = 2, ItemName = "Pencil", Amount = 500},
                new Item() { RollNumber = 2, SalesId = 8, ItemName = "Sans", Amount = 250},
                new Item() { RollNumber = 3, SalesId = 6, ItemName = "Pineapple", Amount = 2200},
                new Item() { RollNumber = 5, SalesId = 12, ItemName = "Rice", Amount = 5050},
                new Item() { RollNumber = 4, SalesId = 10, ItemName = "Cocoa", Amount = 1000},
                new Item() { RollNumber = 7, SalesId = 2, ItemName = "Chalk", Amount = 500},
                new Item() { RollNumber = 9, SalesId = 8, ItemName = "Coca-Cola", Amount = 150},
                new Item() { RollNumber = 1, SalesId = 6, ItemName = "Lemon", Amount = 200},
                new Item() { RollNumber = 8, ItemName = "Cereal", Amount = 650},
                new Item() { RollNumber = 15, ItemName = "Chocolate", Amount = 1000}
            };
        }
    }
}
