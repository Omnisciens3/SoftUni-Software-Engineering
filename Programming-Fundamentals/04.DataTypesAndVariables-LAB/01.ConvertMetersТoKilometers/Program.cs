using System;

namespace _01.ConvertMetersТoKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = meters / 1000.0M; //с 1000.0M - указваме, че е decimal. M - suffix for decimal

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
