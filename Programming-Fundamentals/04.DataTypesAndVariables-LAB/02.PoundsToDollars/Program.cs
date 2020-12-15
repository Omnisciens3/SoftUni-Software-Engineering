using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal gbp = decimal.Parse(Console.ReadLine());
            decimal usd = gbp * 1.31M;

            Console.WriteLine($"{usd:f3}");
        }
    }
}
