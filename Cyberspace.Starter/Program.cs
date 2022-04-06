using System;


namespace Cyberspace.Starter
{
    public class Book
    {
        public string title;
        public string author;
        public string ISBN;

        public void ReadBook()
        {
            Console.WriteLine("This book can been read.");
        }

        public void ShelveBook()
        {
            Console.WriteLine("This book has been shelved.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Car car = new Car(); //Create an instance of the class
            car.DisplayVehicleType("Corolla"); //Inherits the DisplayVehicleType method from Vehicle
            car.GetBrandName();

            Truck truck = new Truck(); //Create an instance of the class
            truck.DisplayVehicleType("Volkswagen"); //Inherits the DisplayVehicleType method from Vehicle
            truck.GetBrandName();

            Motorcycle motorcycle = new Motorcycle(); //Create an instance of the class
            motorcycle.DisplayVehicleType("Vespa"); //Inherits the DisplayVehicleType method from Vehicle
            motorcycle.GetBrandName();


            //Book someBook = new Book();

            //someBook.title = "The Hobbit";
            //someBook.author = "J.R.R Tolkien";
            //someBook.ISBN = "FR-543";

            //someBook.ReadBook();
            //someBook.ShelveBook();
            //Console.WriteLine("Title: {0}\nAuthor: {1}\nISBN: {2}", someBook.title, someBook.author, someBook.ISBN);
        }
        
    }
}
