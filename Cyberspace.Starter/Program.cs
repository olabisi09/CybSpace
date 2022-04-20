using System;

namespace Cyberspace.Starter
{
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

        public static void Method()
        {

        }
        public static int Method2(int a)
        {
            return 0;
        }
    }
    public class Program
    {
        static void Main()
        {
            

            Action action = ArithmeticOperation.Method;
            Func<int, int> func = ArithmeticOperation.Method2;

            Func<int, bool, string> func1 = (a, b) =>
            {
                return "something";
            };

            var myArray = new ArithmeticOperationDelegate[3];
            //or var myArray = new Func<int, int, int>[3];


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

            int i = 0;
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



