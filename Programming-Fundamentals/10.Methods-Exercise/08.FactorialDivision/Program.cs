using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double calculateFirstFactorial = GetFactorial(firstNumber);
            double calculateSecondFactorial = GetFactorial(secondNumber);

            double result = calculateFirstFactorial / calculateSecondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        private static double GetFactorial(int firstNumber)
        {
            double result = 1;
            while (firstNumber != 1)
            {
                result *= firstNumber;
                firstNumber -= 1;
            }
            return result;
        }
    }
}
