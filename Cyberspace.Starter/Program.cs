using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            //AccountTask();
            //DaysOfTheWeek();
            MonthsOfTheYear();
        }

        static void AccountTask()
        {
            var accounts = Account.GetAccounts();
            Task.Run(() =>
            {
                var result = accounts.Sum(a => a.Amount);
                Console.WriteLine($"Sum of amount: {result}");
            });
            Task.Run(() =>
            {
                var names = accounts.Select(a => a.Name);
                Console.WriteLine("Account holder names:");
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            });
            Console.Read();
        }

        static void DaysOfTheWeek()
        {
            var days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }.ToList();
            days.Sort();
            Console.WriteLine("Days of the week in ascending order: ");
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();
        }

        static void MonthsOfTheYear()
        {
            var months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //var newstuff = months.TakeLast(2);
            Console.WriteLine("Months of the year: ");
            foreach (var month in months)
            {
                //Console.WriteLine(month != months.Last() ? month + ", " : month);
                Console.WriteLine(month);
            }
            Console.WriteLine();
            
            Console.WriteLine($"Last two months of the year are {months[months.Count - 2]} and {months[months.Count - 1]}");
        }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Amount { get; set; }
        public string YearOfSpecification { get; set; }

        public static List<Account> GetAccounts()
        {
            return new List<Account>
            {
                new Account { Id = 2, Name = "Amar", Gender = "F", Amount = 400000, YearOfSpecification = "2 years"},
                new Account { Id = 6, Name = "Joe", Gender = "M", Amount = 40000, YearOfSpecification = "2 monnths"},
                new Account { Id = 8, Name = "Tola", Gender = "F", Amount = 800000, YearOfSpecification = "5 days"},
                new Account { Id = 10, Name = "Jude", Gender = "M", Amount = 500000, YearOfSpecification = "6 years"},
                new Account { Id = 12, Name = "Amir", Gender = "F", Amount = 1000000, YearOfSpecification = "1 year"},
                new Account { Id = 14, Name = "Sam", Gender = "F", Amount = 600000, YearOfSpecification = "1 year"},
                new Account { Id = 16, Name = "Joy", Gender = "F", Amount = 100000, YearOfSpecification = "3 years"},
                new Account { Id = 18, Name = "Ola", Gender = "M", Amount = 20000, YearOfSpecification = "4 months"}
            };
        }
    }

    public class Calculator
    {
        //[Obsolete("This method is obsolete. Try again suckers!")]
        public static int Add(int a, int b)
        {
            //Console.WriteLine("MEthod outdated");
            return a + b;
        }

        public static int Add(List<int> numbers)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                result += i;
            }
            return result;
        }
    }
}



