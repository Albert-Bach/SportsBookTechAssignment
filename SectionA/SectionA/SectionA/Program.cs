using System;

namespace SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOne = 1;
            long numberTwo = 1000000;


            Console.WriteLine(SumOfNumbers(numberOne,numberTwo));
            Console.ReadLine();
        }

        public static long SumOfNumbers(long number, long anotherNumber)
        {

            long result = anotherNumber * (number + anotherNumber) / 2;

            return result;
        }
       
    }
}
