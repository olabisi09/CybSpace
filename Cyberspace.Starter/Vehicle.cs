using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Vehicle
    {
        public string brandName = "Toyota";

        public void DisplayVehicleType(string vehicleType)
        {
            Console.WriteLine("This is a {0}", vehicleType);
        }
    }

    public class Car : Vehicle
    {
        public string vehicleType = "Car";
        public void GetBrandName()
        {
            //displays the variable 'brandName' inherited from the Vehicle class.
            Console.WriteLine("Brand: {0}", brandName);
        }
    }

    public class Truck : Vehicle
    {
        public string vehicleType = "Truck";
        public void GetBrandName()
        {
            //displays the variable 'brandName' inherited from the Vehicle class.
            Console.WriteLine("Brand: {0}", brandName);
        }
    }

    public class Motorcycle : Vehicle
    {
        public string vehicleType = "Motorcycle";
        public void GetBrandName()
        {
            //displays the variable 'brandName' inherited from the Vehicle class.
            Console.WriteLine("Brand: {0}", brandName);
        }
    }


    
}