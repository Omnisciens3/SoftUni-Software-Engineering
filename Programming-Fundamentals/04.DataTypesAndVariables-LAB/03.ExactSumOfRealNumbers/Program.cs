using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal realNumbers = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= realNumbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
