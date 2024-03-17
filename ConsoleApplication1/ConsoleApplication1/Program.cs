
using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("test3");
            Console.WriteLine("test3");
            Console.WriteLine("test3");
        }

        public static double Srednia(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum/numbers.Length;
        }
    }
}