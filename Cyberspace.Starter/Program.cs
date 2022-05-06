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
            var taskResult = PrintMoreAsync();
            

            for (int i = 0; i < 5; i++)
            {
                PrintMore($"B{i}");
                Task.Delay(2000).Wait();
            }

            
            PrintMore("Waiting for PrintMoreAsync() to finish");
            int k = await taskResult;
            Console.WriteLine(taskResult);
            Console.Read();
        }

        public static async Task<int> PrintMoreAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                PrintMore($"A{i}");
                await Task.Delay(2000);
            }

            int result = 123;
            Console.WriteLine($"Returns {result}");
            return result;
        }

        public static void PrintMore(string message)
        {
            int threadID = Thread.CurrentThread.ManagedThreadId;
            Console.ForegroundColor = threadID == 1? ConsoleColor.Blue : ConsoleColor.Red;
            string tab = new string(' ', 37 - message.Length);
            Console.WriteLine($"{message}{tab}Thread{threadID}");
        }
    }
}



