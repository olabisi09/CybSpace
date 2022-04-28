using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Employee
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int Designation { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee() { RollNumber = 101, Name = "Monica Geller", Age = 23, Gender = Gender.female, Designation = 3},
                new Employee() { RollNumber = 102, Name = "Ross Geller", Age = 28, Gender = Gender.male, Designation = 3},
                new Employee() { RollNumber = 103, Name = "Phoebe Buffay", Age = 30, Gender = Gender.female, Designation = 1},
                new Employee() { RollNumber = 104, Name = "Chandler Bing", Age = 29, Gender = Gender.male, Designation = 2},
                new Employee() { RollNumber = 105, Name = "Joey Tribbiani", Age = 35, Gender = Gender.male, Designation = 4},
                new Employee() { RollNumber = 106, Name = "Eddie Moskowitz", Age = 32, Gender = Gender.male, Designation = 1},
                new Employee() { RollNumber = 107, Name = "Joshua Burgen", Age = 40, Gender = Gender.male, Designation = 4},
                new Employee() { RollNumber = 108, Name = "Janice Hosenstein", Age = 34, Gender = Gender.female, Designation = 2},
                new Employee() { RollNumber = 109, Name = "Will Culvert", Age = 26, Gender = Gender.male, Designation = 2},
                new Employee() { RollNumber = 110, Name = "Rachel Green", Age = 30, Gender = Gender.female, Designation = 3}
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
