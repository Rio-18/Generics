
using Generics;
using System;

namespace Generics
{
    class Program
    {
       public static void toPrint<T>(T[] inputArray)
       {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }

       }

        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }

        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }

        }

        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            double[] doubleArray = { 1.1, 2.2, 3.3 };
            char[] charArray = { 'H', 'E', 'L', 'L' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<Char>(charArray);

            PrintArray<int> intPrintArray = new PrintArray<int>(intArray);
            intPrintArray.toPrint();

            PrintArray<double> doublePrintArray = new PrintArray<double>(doubleArray);
            intPrintArray.toPrint();

            PrintArray<char> charPrintArray = new PrintArray<char>(charArray);
            intPrintArray.toPrint();

            int num1 = 20, num2 = 30, num3 = 10;
            //int value = num1.CompareTo(num2);
            //Console.WriteLine(value);

            int value = Maximum.MaximumIntegerNumber(num1, num2, num3);
            Console.WriteLine(value+ "is greatest");

        }
        
     }

 }
    
    

  






