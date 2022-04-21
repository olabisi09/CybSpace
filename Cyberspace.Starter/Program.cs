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
        public class CustomException : Exception
        {
            public CustomException(string message) : base(message)
            {

            }
        }
        static void Main()
        {
            try
            {
                int d = 0;
                int i = 5 / d;
                Console.WriteLine(i);
                //throw new CustomException("Custom exception was thrown.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Stuff after the exception");
            }

        }
    }

}



