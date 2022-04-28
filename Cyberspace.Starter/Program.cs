using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            int[] evenNumbers = { 2, 4, 6 };
            int[] oddNumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] sampleNumbers = { 23, 4, 10, 6, 7, 19, 19};
            
            var example = evenNumbers.Where(x => x < 20).Sum(x => x - 20);
            

            var aggExample = evenNumbers.Aggregate((a, b) => a + b * b);
            Console.WriteLine(aggExample);

            var employees = Employee.GetEmployees();
            var someEmployees = employees.All(x => x.RollNumber < 105);

            //union 
            var nums = evenNumbers.Union(oddNumbers).Average(x => x);


            var allNumbers = evenNumbers.Where(x => x > 10).Union(evenNumbers.Where(x => x < 10)).OrderBy(x => x);



            //intersect
            var intersectNumbers = evenNumbers.Intersect(sampleNumbers).OrderBy(x => x);



            //except
            var exceptNumbers = sampleNumbers.Except(evenNumbers);



            //distinct
            var distinctNumbers = sampleNumbers.Distinct();


            //aggregate operators


            //sum
            var aggNums = evenNumbers.Sum(x => x);
 

            var agg = evenNumbers.Aggregate((x, y) => x * y);
            //Console.WriteLine(agg);

            //min
            var minNumbers = sampleNumbers.Min(x => x);
        }
    }
}



