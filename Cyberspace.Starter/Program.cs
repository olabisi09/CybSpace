using System;
using Cyberspace.Library;

namespace Cyberspace.Starter
{
    public class Program
    {
        public static void Main()
        {
            Circle.Area(5.6);
            Employee.SignIn();

            Circle x = new Circle();
            Circle y = new();
            var z = new Circle();
        }
    }
}
