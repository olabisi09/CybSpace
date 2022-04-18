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
            //Animal[] an = new Animal[6] {
            //    new Animal {Name = "Dog"},
            //    new Animal {Name = "Cat"},
            //    new Animal {Name = "Bear"},
            //    new Animal {Name = "Fish"},
            //    new Animal {Name = "Lion"},
            //    new Animal {Name = "Snake"},
            //};
            //Console.Write("Enter the string to find: ");
            //string stringToFind = Console.ReadLine();

            //for (int i = 0; i < an.Length; i++)
            //{
            //    if (an[i].Name == stringToFind)
            //    {
            //        Console.WriteLine($"The string '{stringToFind}' is at index {i} of the array");
            //    }
            //}

            ////Jumoke: Maximum number in an array
            //int[] numbers = { 1, 2, 3, 67, 23, 56, 11 };
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("Maximum = " + max);

            //Console.WriteLine("--------------------");

            ////Moyo: GPA program
            //Console.Write("Enter GPA: ");
            //double gpa = Double.Parse(Console.ReadLine());
            //string whichClass = "";
            //switch (gpa)
            //{
            //    case double x when x >= 4.5 && x <= 5.0:
            //        whichClass = "First Class";
            //        break;
            //    case double x when x >= 3.5 && x <= 4.45:
            //        whichClass = "Second Class Upper";
            //        break;
            //    case double x when x >= 2.5 && x <= 3.45:
            //        whichClass = "Second Class Lower";
            //        break;
            //    case double x when x >= 1.5 && x <= 2.25:
            //        whichClass = "Third Class";
            //        break;
            //    default:
            //        whichClass = "Fail";
            //        break;
            //}
            //Console.WriteLine("Current Grade: " + whichClass);

            ////Olabisi: triangular pattern in ascending order
            //string star = "*";
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= i - 1; j++)
            //    {
            //        Console.Write(star);
            //    }
            //    Console.WriteLine(star);
            //}

            //Console.WriteLine("--------------------");

            ////triangular pattern in descending order
            //for (int i = 6; i >= 1; i--)
            //{
            //    for (int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(star);
            //    }
            //    Console.WriteLine(star);
            //}

            //Console.WriteLine("--------------------");

            //rectangular pattern
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if(i == 1 ||j == 1 || i == 4|| j == 6)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

