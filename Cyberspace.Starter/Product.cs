using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }   
        public int Quantity { get; set; }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return Quantity.CompareTo(other.Quantity);
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj == null) return 1;
        //    Product product = obj as Product;
        //    if (product == null) return -1;
        //    else return 0;
        //}

        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}";
        }
    }
}
