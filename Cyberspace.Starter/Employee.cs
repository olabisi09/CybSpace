using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { FirstName = "Jude", LastName = "Smith", Age = 41},
                new Employee { FirstName = "Sarah", LastName = "Jones", Age = 22},
                new Employee { FirstName = "Stacy", LastName = "Baker", Age = 21},
                new Employee { FirstName = "Samuel", LastName = "Dexter", Age = 17},
                new Employee { FirstName = "Richy", LastName = "Smith", Age = 49},
                new Employee { FirstName = "Brett", LastName = "Joy", Age = 51},
                new Employee { FirstName = "Mark", LastName = "Parker", Age = 116},
                new Employee { FirstName = "Alice", LastName = "Thompson", Age = 18},
                new Employee { FirstName = "Evelyn", LastName = "Winsome", Age = 58 },
                new Employee { FirstName = "Mort", LastName = "Martin", Age = 58},
                new Employee { FirstName = "Eugene", LastName = "deLauter", Age = 84},
                new Employee { FirstName = "Gail", LastName = "Dude", Age = 34}
            };
        }
    }

    public enum Gender
    {
        male,
        female
    }

    public class Salary
    {
        public int Id { get; set; }
        public string LineManager { get; set; }
        public double SalaryAmount { get; set; }

        public static List<Salary> GetSalaries()
        {
            return new List<Salary> 
            {
                new Salary{Id = 1, LineManager = "Joanna Bush", SalaryAmount = 3500},
                new Salary{Id = 2, LineManager = "John Doe", SalaryAmount = 5000},
                new Salary{Id = 3, LineManager = "Kyle Libbett", SalaryAmount = 7000},
                new Salary{Id = 4, LineManager = "Lonnie Litt", SalaryAmount = 4760},
            };
        }
    }
}
