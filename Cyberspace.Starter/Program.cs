using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Program
    {
        static async Task Main()
        {
            //var task = new Task[2];
            //string[] files = null; 
            //string[] dir = null;

            //string docDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
            //task[0] = Task.Run(() => files = Directory.GetFiles(docDirectory));
            //task[1] = Task.Factory.StartNew(() => dir = Directory.GetDirectories(docDirectory));

            //Task.Factory.ContinueWhenAll(task, completedFile =>
            //{
            //    Console.WriteLine($"{docDirectory} contains");
            //    Console.WriteLine($"{files.Length} files");
            //    Console.WriteLine($"{dir.Length} sub-directories");
            //});
            

            var x = Task.Run(() => Multiply());
            var y = Task.Run(() => Add());
            Console.WriteLine($"Multiply: {x}, Add: {y}");
            Console.Read();
        }

        //static async Task<int> Multiply()
        //{
        //    Thread.Sleep(2000);
        //    Console.WriteLine("Multiplying...");
        //    return 5 * 8;
        //}

        //static async Task<int> Add()
        //{
        //    Console.WriteLine("Adding...");
        //    return 5 + 8;
        //}

        static int Multiply()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Multiplying...");
            return 5 * 8;
        }

        static int Add()
        {
            Console.WriteLine("Adding...");
            return 5 + 8;
        }
    }
}



