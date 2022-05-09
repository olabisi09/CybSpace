using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Calculating...");
            await Calculate();
            
            //Console.Read();
        }

        public static async Task Calculate()
        {
            await Task.Run(() => One());
            await Task.Run(() => Two());
            await Task.Run(() => Three());
        }

        public static async Task<int> One()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating one...");
            return 100;
        }

        public static async Task<int> Two()
        {
            Console.WriteLine("Calculating two...");
            return 200;
        }

        public static async Task<int> Three()
        {
            Console.WriteLine("Calculating three...");
            return 300;
        }
    }
}



