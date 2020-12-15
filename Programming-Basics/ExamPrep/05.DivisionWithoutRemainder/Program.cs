using System;

namespace _05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numbersDividedByTwo = 0;
            int numbersDividedByThree = 0;
            int numbersDividedByFour = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    numbersDividedByTwo++;
                }
                if (number % 3 == 0)
                {
                    numbersDividedByThree++;
                }
                if (number % 4 == 0)
                {
                    numbersDividedByFour++;
                }
            }
            double p1 = numbersDividedByTwo * 1.0 / n * 100;
            double p2 = numbersDividedByThree * 1.0 / n * 100;
            double p3 = numbersDividedByFour * 1.0 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
