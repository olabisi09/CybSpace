using System;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            Func<int, int, int> func = (int x, int y) => x + y;
            Arith.Add((x, y) => x + y);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int counter = 0;
            

            Action<int> timesTwo = (int x) => 
            {
                numbers[counter] = x * 2;
                counter++;
            };
            Array.ForEach(numbers, timesTwo);

            //shorter way of doing the above
            Array.ForEach(numbers, (int x) =>
            {
                numbers[counter] = x * 2;
                counter++;
            });
            var arith = new Arith();
            arith.Prop = x => x * 2;
        }

        public class Arith
        {
            public Func<int, int> Prop { get; set; }
            public static int Add(Func<int, int, int> sum)
            {
                return sum(3, 6);
            }
        }
    }

}



