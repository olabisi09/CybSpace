using System;
using System.Collections;
using System.Collections.Generic;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            //Demonstrating IEnumerable
            var cars = new Car[]
            {
                new Car(){Brand = "Lexus", Year = 2012},
                new Car(){Brand = "BMW", Year = 2019}
            };

            var vehicles = new Vehicle(cars);

            foreach (var c in vehicles)
            {
                Console.WriteLine(c);
            }

            //Demonstrating IComparable
            var people = new PersonDetails[]
            {
                new PersonDetails(2, "John Doe"),
                new PersonDetails(1, "Hanna Brown"),
                new PersonDetails(5, "Davy Jones")
            };
            Array.Sort(people);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            //list does the job of Array, but builds upon it by being able to add to the list and increasing the number of items it can take
            var list = new List<string>() { "John", "Jane", "Hanna"}; //using a collection initializer
            Console.WriteLine("Capacity of list: " + list.Capacity);
        }
    }
}



