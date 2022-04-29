using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            string[] keywords = { "abstract", "add*", "alias*", "as", "ascending*", "async*", "await", "base", "bool", "break", "by*", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "descending*", "do", "double", "dynamic*", "else", "enum", "event", "equals", "explicit", "extern", "false", "finally", "fixed", "from*", "float", "for", "foreach", "get*", "global*", "group*", "goto", "if", "implicit", "in", "int", "into*", "interface", "internal", "is", "lock", "long", "join*", "let*", "nameof*", "namespace", "new", "null", "object", "on*", "operator", "orderby*", "out", "override", "params", "partial*", "private", "protected", "public", "readonly", "ref", "remove*", "return", "sbyte", "sealed", "select*", "set*", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unsafe", "ushort", "using", "value*", "var*", "virtual", "unchecked", "void", "volatile", "where*", "while", "yield*"};

            //Question 1 - 3
            var containsE = keywords.Where(x => x.Contains('e')).Select(x => x).OrderBy(x => x);

            Console.WriteLine("Words that contain the letter 'e' include: ");
            foreach (var x in containsE)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            
            //Question 4
            var last = keywords.Last();
            Console.WriteLine($"Last word in the list: {last}");
            Console.WriteLine();

            //Question 5
            var containsAsterisk = keywords.Where(x => x.Contains('*')).Select(x => x).OrderBy(x => x);
            Console.WriteLine("Words that contain '*' include: ");
            foreach (var x in containsAsterisk)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            var employees = Employee.GetEmployees();

            var lastNamesD = employees.Where(x => x.LastName.StartsWith("d", StringComparison.CurrentCultureIgnoreCase)).Select(x => x);
            Console.WriteLine("Employees with last names starting with D:");
            foreach (var employee in lastNamesD)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine();

            var olderThan40 = employees.Where(x => x.Age > 40).OrderByDescending(x => x.FirstName);
            Console.WriteLine("Employees older than 40:");
            foreach (var employee in olderThan40)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine();

            var firstPersonOlderThan40 = olderThan40.First();
            Console.WriteLine($"First person older than 40 in descending order: {firstPersonOlderThan40.FirstName} {firstPersonOlderThan40.LastName}\n");

            var words = new List<string>() { "plane", "ferry", "car", "bike" };
            words.Sort();
            var containsEAgain = words.Where(x => x.Contains("e")).Select(x => x);
            Console.WriteLine("Words that contain the letter 'e':");
            foreach (var word in containsEAgain)
            {
                Console.WriteLine(word);
            }
        }
    }
}



