using System;

namespace Cyberspace.Starter
{
    public static class Extension
    {
        public static bool isValidTelNo(this string x)
        {
            return x.Length == 11 ? true : false;
        }

        public static int SearchByKeyword(this string input, string key)
        {
            return input.IndexOf(key, StringComparison.InvariantCultureIgnoreCase);
        }
    }
    public class Program
    {
        static void Main()
        {
            //Console.Write("Enter something: ");
            //string s = Console.ReadLine();
            //if (s.isValidTelNo())
            //{
            //    Console.WriteLine(s);
            //}

            string sentence = "This is a boy";
            string searchKeyword = Console.ReadLine();
            int index = sentence.SearchByKeyword(searchKeyword);
            Console.WriteLine(index);
        }
    }

}



