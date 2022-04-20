using System;

namespace Example
{
    public delegate int AddDelegate(int x, int y);

    public class Program
    {
        static void Main(string[] args)
        {
            AddDelegate addDelegate = new AddDelegate(AddStuff);

            addDelegate = addDelegate + SubtractStuff + MultiplyStuff;

            Console.WriteLine(addDelegate(78, 32));
        }

        public static int AddStuff(int x, int y)
        {
            return x + y;
        }
        public static int SubtractStuff(int x, int y)
        {
            return x - y;
        }
        public static int MultiplyStuff(int x, int y)
        {
            return (x * y);
        }
    }
}
