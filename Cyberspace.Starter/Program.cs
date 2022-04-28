using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            //element operations in LINQ

            //First(), FirstOrDefault(), Last(), LastOrDefault()
            int[] numbers = {1, 2, 3, 4, 5, 6};
            Console.WriteLine(numbers.LastOrDefault());

            //Single(), SingleOrDefault()
            var some = numbers.Single();
            var all = numbers.SingleOrDefault(x => x >= 3);
            Console.WriteLine(all);
        }
    }
}



