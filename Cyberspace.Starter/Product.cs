using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Product : IComparer<Product>
    {
        public string Name { get; set; }   
        public int Quantity { get; set; }

        public int Compare(Product x, Product y)
        {
            return x.Quantity.CompareTo(y.Quantity);
        }

        //public int CompareTo(Product other)
        //{
        //    if (other == null) return 1;
        //    return Quantity.CompareTo(other.Quantity);
        //}

        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}";
        }
    }
}
