using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Vehicle : IEnumerable
    {
        private readonly VehicleEnumerator vehicleEnumerator;
        public Vehicle(Car[] cars)
        {
            vehicleEnumerator = new VehicleEnumerator(cars);
        }
        public IEnumerator GetEnumerator()
        {
            return vehicleEnumerator;
        }
    }

    public class VehicleEnumerator : IEnumerator
    {
        public Car[] CarList { get; set; }
        public VehicleEnumerator(Car[] vehicles)
        {
            this.CarList = vehicles;
        }

        private int counter = -1;
        public object Current => CarList[counter];

        public bool MoveNext()
        {
            counter++;
            if (counter > CarList.Length - 1) return false;
            return true;
        }

        public void Reset()
        {
            counter = -1;
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand}, Year: {Year}";
        }
    }


    
}