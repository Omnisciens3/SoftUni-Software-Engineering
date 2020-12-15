using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            GetSumOfEvenDigits(input);
            GetSumOfOddDigits(input);
            GetMultiply(input);

            int result = GetMultiply(input);
            Console.WriteLine(result);
        }

        private static int GetMultiply(int number)
        {
            int result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sumOfOdd = 0;
            while (number != 0)
            {
                int digit = Math.Abs(number) % 10;

                if (digit % 2 != 0)
                {
                    sumOfOdd += digit;
                }
                number /= 10;
            }
            return sumOfOdd;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;
            while (number != 0)
            {
                int digit = Math.Abs(number) % 10;

                if (digit % 2 == 0)
                {
                    sumOfEven += digit;
                }
                number /= 10;
            }
            return sumOfEven;
        }
    }
}
