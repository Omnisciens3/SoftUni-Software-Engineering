using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Print(number);
        }

        static void Print(int number)
        {
            string sign = string.Empty;

            if (number < 0)
            {
                sign = "negative";
            }
            else if (number > 0)
            {
                sign = "positive";
            }
            else if (number == 0)
            {
                sign = "zero";
            }
            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
