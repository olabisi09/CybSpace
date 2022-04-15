using System;


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
            //Damilare: Find a string in an array of objects
            Animal[] an = new Animal[6] {
                new Animal {Name = "Dog"},
                new Animal {Name = "Cat"},
                new Animal {Name = "Bear"},
                new Animal {Name = "Fish"},
                new Animal {Name = "Lion"},
                new Animal {Name = "Snake"},
            };
            Console.Write("Enter the string to find: ");
            string stringToFind = Console.ReadLine();

            for (int i = 0; i < an.Length; i++)
            {
                if (an[i].Name == stringToFind)
                {
                    Console.WriteLine($"The string '{stringToFind}' is at index {i} of the array");
                }
            }

            //Jumoke: Maximum number in an array
            int[] numbers = { 1, 2, 3, 67, 23, 56, 11 };
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Maximum = " + max);

            Console.WriteLine("--------------------");

            //Olabisi: triangular pattern in ascending order
            string star = "*";
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine(star);
            }

            Console.WriteLine("--------------------");

            //triangular pattern in descending order
            for (int i = 6; i >= 1; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(star);
                }
                Console.WriteLine(star);
            }

            Console.WriteLine("--------------------");

            //rectangular pattern
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if((j != 1 || j != 5))
                    {
                        Console.Write(star);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine(star);
            }
        }
    }
}

