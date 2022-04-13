using System;


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
        
        static void Main()
        {
            Container container = new Container();
            container.Notify += NotifyFinish;
            container.NotifyStart();

            static void NotifyFinish() 
            {
                Console.WriteLine("All done with the event.");
            }

            
            
        }
    }

}



