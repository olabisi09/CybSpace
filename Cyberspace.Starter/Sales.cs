using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Sales
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string CategoryName { get; set; }
    }

    public class Item
    {
        public int RollNumber { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double Amount { get; set; }

    }
}
