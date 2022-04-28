using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            var sales = Sales.GetSales();
            var items = Item.GetItems();

            var joinStuff = sales.GroupJoin(items, x => x.Id, y => y.SalesId, (x, groupedItems) => new
            {
                x.Id, x.CategoryName,
                groupedItems
            });

            var altJoinStuff = from x in sales
                               join y in items
                               on x.Id equals y.SalesId into groups
                               select new
                               {
                                   x.Id,
                                   x.CategoryName,
                                   groups
                               };

            foreach (var item in altJoinStuff)
            {
                Console.WriteLine($"{item.CategoryName} has the following items:");
                foreach (var result in item.groups)
                {
                    Console.WriteLine($"Id: {result.SalesId}, Item name: {result.ItemName}, Amount: {result.Amount}");
                }
                Console.WriteLine();
            }

            var sum = items.Sum(x => x.Amount);
            Console.WriteLine($"Total sales: {sum}");

            var averageRollNo = items.Average(x => x.RollNumber);
            Console.WriteLine($"Average of roll numbers: {averageRollNo}");
        }
    }
}



