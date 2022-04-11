using System;


namespace Cyberspace.Starter
{
   public class ShoppingBag<T> where T : Bag
    {
        public T[] items = new T[5];
        int _index = 0;
        public void AddItem(T bags)
        {
            items[_index++] = bags;
        }

        public T GetItem(int index)
        {
            return items[index];
        }
    }

    public class Bag
    {
        public string Name { get; set; }  
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nCount: {Count}";
        }
    }

    public class Program
    {
        static void Main()
        {
            var shoppingBag = new ShoppingBag<Bag>();
            shoppingBag.AddItem(new Bag() { Name = "Spaghetti", Count = 20});
            shoppingBag.AddItem(new Bag() { Name = "Rice", Count = 34 });
            var counter = 0;
            while (counter < 5)
            {
                Console.WriteLine(shoppingBag.GetItem(counter));
                counter++;
            }
            shoppingBag.GetItem(3);
        }
        
    }

}



