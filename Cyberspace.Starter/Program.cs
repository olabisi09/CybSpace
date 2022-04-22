using System;
using System.Collections;
using System.Collections.Generic;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("ID", 1);
            dictionary["Age"] = 20;

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            return;
            SortedSet<int> s = new SortedSet<int>() { 44, 53, 1, 98, 4 };
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Un");
            queue.Enqueue("Deux");
            queue.Dequeue();
            Console.WriteLine(queue.Contains("Deux"));

            Stack<string> stack = new Stack<string>();
            stack.Push("Trois");

            Console.WriteLine(stack);
        }
    }
}



