using System;


namespace Cyberspace.Starter
{
    public delegate int MyDelegate(int x, int y);
    public delegate int Arithmetic<Z>(Z x, Z y);

    //Classwork
    public delegate int ArithmeticOperationDelegate(int a, int b);

    public class ArithmeticOperation
    {
        public static int Add(int i, int j)
        {
            return i + j;
        }
        public static int Minus(int i, int j)
        {
            return i - j;
        }
        public static int Multiply(int i, int j)
        {
            return i * j;
        }
    }
    public class Program
    {
        
        static void Main()
        {
            var myArray = new ArithmeticOperationDelegate[3];
            int i = 0;

            //Using a for loop

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        myArray[i] = ArithmeticOperation.Add;
            //    }
            //    else if (i == 1)
            //    {
            //        myArray[i] = ArithmeticOperation.Minus;
            //    }
            //    else if (i == 2)
            //    {
            //        myArray[i] = ArithmeticOperation.Multiply;
            //    }

            //    var result = myArray[i];

            //    Console.WriteLine("Method: " + result(50, 40));
            //}

            //Using a switch statement
            switch (i)
            {
                case 0:
                    myArray[i] = ArithmeticOperation.Add;
                    Console.WriteLine("Method: " + myArray[i](50, 40));
                    goto case 1;
                case 1:
                    myArray[i] = ArithmeticOperation.Minus;
                    Console.WriteLine("Method: " + myArray[i](50, 40));
                    goto default;
                default:
                    myArray[i] = ArithmeticOperation.Multiply;
                    Console.WriteLine("Method: " + myArray[i](50, 40));
                    break;
            }
            
        }
    }

}



