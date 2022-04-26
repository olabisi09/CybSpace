using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static string[] words = { "uno", "dos", "tres", "cuarto", "cinco" };
        static void Main()
        {
            //var z = new List<Items>()
            //{
            //    new Items() {Id = 1, Name = "Book", Price = 1200, Quantity = 9},
            //    new Items() {Id = 2, Name = "Pen", Price = 350.50, Quantity = 20},
            //    new Items() {Id = 3, Name = "Glue", Price = 200, Quantity = 15},
            //};

            ////var res = z.Where(x => x.Quantity < 50)
            ////    .OrderByDescending(x => x.Price)
            ////    .ThenBy(x => x.Name)
            ////    .Select(x => (name: x.Name, quantity: x.Quantity));

            //var dict = z.GroupBy(x => x.Name).Select(x => (x.Key, price: x.Select(x => x.Price)));
            //foreach (var item in dict)
            //{
            //    Console.WriteLine($"{item.Key}");
            //    foreach (var item2 in item.price)
            //    {
            //        Console.WriteLine($"\tName: {item2}");
            //    }
            //}

            var employees = new List<Employee>(){
                new Employee() { Id = 1, Name = "Monica Geller", Age = 23, Gender = "female", Salary = 3500},
                new Employee() { Id = 2, Name = "Ross Geller", Age = 28, Gender = "male", Salary = 3000},
                new Employee() { Id = 3, Name = "Phoebe Buffay", Age = 30, Gender = "female", Salary = 4500},
                new Employee() { Id = 4, Name = "Chandler Bing", Age = 29, Gender = "male", Salary = 5500},
                new Employee() { Id = 5, Name = "Joey Tribbiani", Age = 35, Gender = "male", Salary = 6370},
                new Employee() { Id = 6, Name = "Eddie Moskowitz", Age = 32, Gender = "male", Salary = 2400},
                new Employee() { Id = 7, Name = "Joshua Burgen", Age = 40, Gender = "male", Salary = 6400},
                new Employee() { Id = 8, Name = "Janice Hosenstein", Age = 34, Gender = "female", Salary = 4000},
                new Employee() { Id=9, Name = "Will Culvert", Age = 26, Gender = "male", Salary = 6250},
                new Employee() { Id = 10, Name = "Rachel Green", Age = 30, Gender = "female", Salary = 7000}
            };

            var olderThan25 = employees.Where(employee => employee.Age > 25).OrderByDescending(employee => employee.Name).Select(employee => employee);
            Console.WriteLine("Employees older than 25:");
            foreach(var result2 in olderThan25)
            {
                Console.WriteLine($"Name: {result2.Name}, Age: {result2.Age}");
            }
            Console.WriteLine();

            var femaleEmployees = employees.Where(employee => employee.Gender == "female").Select(employee => employee);
            Console.WriteLine("Female employees:");
            foreach (var result3 in femaleEmployees)
            {
                Console.WriteLine($"Name: {result3.Name}");
            }
            Console.WriteLine();

            var notTheseAges = employees.Where(employee => employee.Age == 20 || employee.Age == 30 || employee.Age == 35).Select(employee => employee);
            Console.WriteLine("Employees that aren't 20, 30 or 35 years old:");
            foreach(var result4 in notTheseAges)
            {
                Console.WriteLine($"Name: {result4.Name}, Age: {result4.Age}");
            }

            Console.WriteLine();

            var idOfOneToEight = employees.Where(employee => employee.Id >= 1 && employee.Id <= 8).Select(employee => employee);
            Console.WriteLine("Employees of IDs betwee 1 and 8");
            foreach(var result5 in idOfOneToEight)
            {
                Console.WriteLine($"Name: {result5.Name}, Age: {result5.Id}");
            }
        }
    }
     
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        
        public double Price { get; set; }
    }
}



