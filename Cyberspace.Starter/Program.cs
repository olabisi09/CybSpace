using System;


namespace Cyberspace.Starter
{
    public class Program
    {
        public static void Main()
        {
            string star = "*";

            //in ascending order
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine(star);
            }

            Console.WriteLine("--------------------");

            //in descending order
            for (int i = 6; i >= 1; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(star);
                }
                Console.WriteLine(star);
            }
        }
    }
}
