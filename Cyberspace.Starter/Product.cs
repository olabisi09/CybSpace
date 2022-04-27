using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    //public class Product : IOrder
    //{
    //    public string Name { get; set; }   
    //    public int Quantity { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Name: {Name}, Quantity: {Quantity}";
    //    }
    //}

    //public class SortProducts<T> : IComparer<T> where T : IOrder
    //{
    //    public int Compare(T x, T y)
    //    {
    //        if (x.Order < y.Order) return 1;
    //        if (x.Order > y.Order) return -1;
    //        else return 0;
    //    }
    //}

    //public abstract class IOrder
    //{
    //    public int Order { get; set; }
    //}

    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}";
        }
    }

    public class SortProducts : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Quantity == y.Quantity) return 0;
            if (x.Quantity < y.Quantity) return 1;
            else return -1;
        }
    }
}
