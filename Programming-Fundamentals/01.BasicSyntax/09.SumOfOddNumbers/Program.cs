using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfOdd = 0;

            for (int i = 1; i <= n * 2; i+=2)
            {
                sumOfOdd += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum: {sumOfOdd}");
        }
    }
}
