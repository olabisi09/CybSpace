using System;
using System.Threading;

namespace Cyberspace.Starter
{
    public delegate void Notify();

    public class Container
    {
        public event Notify Notify;

        public void NotifyStart()
        {
            Console.WriteLine("Some special event happened.");
            OnNotify();
        }

        protected virtual void OnNotify()
        {
            Notify.Invoke();
        }
    }

    public class Program
    {
        public static void PrintStuff(params int[] numbers)
        {
           foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static void Main()
        {
            Container container = new Container();
            container.Notify += NotifyFinish;
            container.NotifyStart();

            static void NotifyFinish() 
            {
                Console.WriteLine("All done with the event.");
            }
            // Thread.Sleep(3000); makes the code pause running for a specified number of milliseconds.
            PrintStuff(1, 2, 4, 5);
        }
    }

}



