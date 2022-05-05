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

        public List<string> Skillsets { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { FirstName = "Jude", LastName = "Smith", Age = 41, Skillsets = new List<string> {"UI design", "Web design"} },
                new Employee { FirstName = "Sarah", LastName = "Jones", Age = 22, Skillsets = new List<string> {"JavaScript", "React"}},
                new Employee { FirstName = "Stacy", LastName = "Baker", Age = 21, Skillsets = new List<string> {"Laravel", ".NET"}},
                new Employee { FirstName = "Samuel", LastName = "Dexter", Age = 17, Skillsets = new List<string> {"UI design", "React"}},
                new Employee { FirstName = "Richy", LastName = "Smith", Age = 49, Skillsets = new List<string> {"HTMl", "CSS"}},
                new Employee { FirstName = "Brett", LastName = "Joy", Age = 51, Skillsets = new List<string> {"TailwindCSS", "Nuxt.js"}},
                new Employee { FirstName = "Mark", LastName = "Parker", Age = 116, Skillsets = new List<string> {"JavaScript", "Vue.js"}},
                new Employee { FirstName = "Alice", LastName = "Thompson", Age = 18, Skillsets = new List<string> {"UI design", "Adobe XD"}},
                new Employee { FirstName = "Evelyn", LastName = "Winsome", Age = 58, Skillsets = new List<string> {"VB.NET", "UI design"} },
                new Employee { FirstName = "Mort", LastName = "Martin", Age = 58, Skillsets = new List<string> {"PHP", "Wordpress"}},
                new Employee { FirstName = "Eugene", LastName = "deLauter", Age = 84, Skillsets = new List<string> {"UI design", "Web design"}},
                new Employee { FirstName = "Gail", LastName = "Dude", Age = 34, Skillsets = new List<string> {"UI design", "Web design"}}
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
