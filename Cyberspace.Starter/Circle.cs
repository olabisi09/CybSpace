using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Circle
    {
        public const double pi = 3.14;
        static Circle()
        {
            
        }

        

        public static void Area(double radius)
        {
            Console.WriteLine(pi * radius * radius);
        }

        private void Circumference(double radius)
        {
            Console.WriteLine(2 * pi * radius);
        }
    }
}
