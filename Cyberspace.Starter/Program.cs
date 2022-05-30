using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberspace.Starter
{
    public class Animal
    {
        public string Name { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var products = new List<Product>()
            {
                new Product() { Name = "Quaker Oats", Quantity = 23},
                new Product() { Name = "Fruit 'n' Fibre", Quantity = 30},
                new Product() { Name = "Kotex", Quantity = 45},
                new Product() { Name = "Maryland Cookies", Quantity = 57},
                new Product() { Name = "Cadbury Fingers", Quantity = 20},
                new Product() { Name = "Jacob's Water", Quantity = 62},
                new Product() {Name = "Golden Penny Spaghetti", Quantity = 12},
                new Product() { Name = "Home County Ice Cream", Quantity = 105},
                new Product() { Name = "Head and Shoulders", Quantity = 33},
                new Product() {Name = "Lipton Tea", Quantity = 63}
            };
            products.Sort(new SortProducts());

            //products.ForEach(p => Console.WriteLine(p.ToString()));
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            //int[] arr = {1,1};
            //char[] arr2 = { 'a', 'b', 'c' };
            //Console.WriteLine(StartIndex(arr2, 1, 2));

            int[] x = { 1, 3, 6, 4, 7, 2 };
            int y = Enumerable.Range(1, 100000).Except(x).Min();
            Console.WriteLine(y);
            
        }

        static int[] ShiftArray(int[] A, int K)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                i += 1;
                if (i == A.Length - 1)
                {
                    i = 0;
                }
            }
            return A;
        }

        static int GetOtherInteger(int[] A)
        {
            int max = A[0];
            int res = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            if (max > 0) max += 1;
            else
            {
                while (max <= 0)
                {
                    max += 1;
                }
            }
            return max;
        }

        static int GetPassword(string s)
        {
            string[] words = s.Split(" ");
            int len = 0;
            int maxlen = 0;

            foreach (var word in words)
            {
                bool isLetOrDigit = word.All(x => Char.IsLetterOrDigit(x));
                bool evenLetters = word.Count(x => Char.IsLetter(x)) % 2 == 0;
                bool oddNumbers = word.Count(x => Char.IsDigit(x)) % 2 != 0;

                if (isLetOrDigit && evenLetters && oddNumbers)
                {
                    len = word.Length;
                }
                else
                {
                    maxlen = Math.Max(maxlen, len);
                }
            }
            return maxlen;
        }

        static int GetGap(int n) //10001001
        {
            int gap = 0;
            int maxgap = 0;
            string com = Convert.ToString(n, 2);

            foreach (var i in com)
            {
                if (i == '0')
                {
                    gap++;
                }
                else
                {
                    maxgap = Math.Max(maxgap, gap);
                    gap = 0;
                }
            }
            return maxgap;
        }

        static int[] Common(int[] arr1, int[] arr2)
        {
            int[] result = {};

            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        result[i] = arr1[i];
                    }
                }
            }

            return result;
        }

        static int IsCentered(int[] oddArray)
        {
            int middleElementIndex = (oddArray.Length - 1) / 2;
            if (oddArray.Length == 1) return 1;
            for (int i = 0; i < oddArray.Length; i++)
            {
                if (oddArray[i] > oddArray[middleElementIndex])
                {
                    return 1;
                }
                
            }
            return 0;
        }

        static int OddAndEvenDiff(int[] arr)
        {
            int oddSum = 0; 
            int evenSum = 0;

            if (arr.Length == 0) return 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else oddSum += arr[i];
            }

            return oddSum - evenSum;
        }

        static char[] StartIndex(char[] arr, int start, int len)
        {
            if (len < 0 || start < 0 || start + len - 1 >= arr.Length) return null;
            char[] result = new char[len];
            for (int i = start, j = 0; j < len; i++, j++)
            {
                result[j] = arr[i];
            }
            return result;
        }
    }
}

