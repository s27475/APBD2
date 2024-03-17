
using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Srednia(tab));
            Console.WriteLine(MaxInt(tab));
        }

        public static double Srednia(int[] numbers)
        {
            double sum = 0;
            foreach (int zmienna2 in numbers)
            {
                sum += zmienna2;
            }
            return sum/numbers.Length;
        }
        
        public static int MaxInt(int[] numbers)
        {
            int maxint = numbers[0];
            for(int i=1; i<numbers.Length; i++)
            {
                if (maxint < numbers[i])
                {
                    maxint = numbers[i];
                }
            }

            return maxint;
        }
    }
}