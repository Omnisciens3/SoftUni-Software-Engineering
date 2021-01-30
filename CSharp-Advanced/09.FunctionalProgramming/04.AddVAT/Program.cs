using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(double.Parse)
                                                .Select(price => price += price * 0.2) //Select.
                                                .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f}");
            }
        }
    }
}
