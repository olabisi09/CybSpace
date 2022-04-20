using System;

namespace Cyberspace.Starter
{
    public class Overload
    {
        public int X { get; set; }
        public static bool operator ==(Overload left, Overload right)
        {
            bool result = false;
            result = left.X == right.X ? true : false;
            return result;
        }
        public static bool operator !=(Overload left, Overload right)
        {
            bool result = false;
            result = left.X == right.X ? false : true;
            return result;
        }

        public static bool operator >=(Overload left, Overload right)
        {
            bool result = false;
            result = left.X >= right.X ? true : false;
            return result;
        }

        public static bool operator <=(Overload left, Overload right)
        {
            bool result = false;
            result = left.X <= right.X ? true : false;
            return result;
        }

    }
    public class Program
    {
        static void Main()
        {
            Overload overload = new Overload() { X = 90};
            Overload overload2 = new Overload() { X = 90 };
            bool result = overload == overload2;
            Console.WriteLine(result);
        }
    }

}



