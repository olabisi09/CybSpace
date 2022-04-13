using System;

namespace Cyberspace.Starter
{
    public class Review : IFruit
    {
        public string Name { get => "Olabisi";}

        public void PrintApple(string text)
        {
            Console.WriteLine(text);
        }
    }

    public interface IFruit
    {
        public string Name { get; }
        public void PrintApple(string text);
    }

}