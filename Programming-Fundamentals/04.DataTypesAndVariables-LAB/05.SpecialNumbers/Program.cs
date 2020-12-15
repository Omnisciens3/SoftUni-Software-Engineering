using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;

                Console.Write(i + " ");

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                }
                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                if (isSpecial)
                {
                    Console.WriteLine("-> True");
                }
                else
                {
                    Console.WriteLine("-> False");
                }
            }
        }
    }
}
