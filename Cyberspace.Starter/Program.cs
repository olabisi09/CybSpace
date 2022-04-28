using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            var employees = Employee.GetEmployees();
            var lineManager = Salary.GetSalaries();

            mylabel1:
            //Left outer join: query syntax
            var leftOuterJoinQuery = from x in lineManager
                                 join y in employees
                                 on x.Id equals y.Designation into groupedEmployees
                                 from g in groupedEmployees.DefaultIfEmpty()
                                 select new
                                 {
                                     x.Id,
                                     x.LineManager,
                                     groupedEmployees = g == null ? "No employees in this category." : g.Name,
                                     groupedNumber = g == null ? 0 : g.RollNumber
                                 };
            goto mylabel1;

            //Group join: query syntax
            var groupJoinQuery = from x in lineManager
                              join y in employees
                              on x.Id equals y.Designation
                              into groupedEmployees
                              select new
                              {
                                  x.Id,
                                  x.LineManager,
                                  groupedEmployees
                              };

            foreach (var item in leftOuterJoinQuery)
            {
                Console.WriteLine($"Name: {item.LineManager}, Roll Number: {item.groupedNumber}");
            }

            foreach (var employee in groupJoinQuery)
            {
                Console.WriteLine($"{employee.LineManager} manages the following employees:");
                foreach (var under in employee.groupedEmployees)
                {
                    Console.WriteLine($"Name: {under.Name}, Roll Number {under.RollNumber}");
                }
                Console.WriteLine();
            }


            //Group join: extenstion method syntax
            var groupJoinExtension = lineManager.GroupJoin(employees, x => x.Id, y => y.Designation, (x, groupedEmployees) => new
            {
                x.LineManager,
                groupedEmployees
            });

            foreach (var employee in groupJoinExtension)
            {
                Console.WriteLine($"{employee.LineManager} manages the following employees:");
                foreach (var under in employee.groupedEmployees)
                {
                    Console.WriteLine($"Name: {under.Name}, Roll Number {under.RollNumber}");
                }
                Console.WriteLine();
            }



            //Join or inner join: Using the query syntax
            var innerJoinQuery = from employee in employees
                                 join manager in lineManager
                                 on employee.Designation
                                 equals manager.Id
                                 select new
                                 {
                                     employee.Name,
                                     manager.LineManager,
                                     employee.Gender
                                 };


            //Join or inner join: Using the extension method syntax
            var innerJoinExtension = employees.Join(lineManager, x => x.Designation, y => y.Id, (x, y) => new
            {
                x.Name,
                y.LineManager,
                y.SalaryAmount
            }).Where(y => y.SalaryAmount < 5000).OrderByDescending(x => x.Name);

            foreach (var line in innerJoinExtension)
            {
                Console.WriteLine($"Employee name: {line.Name}, Line Manager: {line.LineManager}, Designation: {line.SalaryAmount}");
            }
        }
    }
}



