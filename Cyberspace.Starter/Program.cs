using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            //Quantifiers
            //.Any(), All() SelectMany()
            var employees = Employee.GetEmployees();

            var checkAny = employees.Any(x => x.Age == 22);
            var checkAll = employees.Any(x => x.Age == employees[0].Age);

            var checkOne = employees.SelectMany(x => x.Skillsets, (x, y) => new
            {
                firstName = x.FirstName,
                lastName = x.LastName,
                skills = y
            });

            var dictionary = employees.ToDictionary(x => x.FirstName);

            foreach (var check in dictionary.Keys)
            {
                Console.WriteLine($"Key: {check}, Value: {dictionary[check].Age}");
            }
        }
    }
}



