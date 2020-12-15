using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;

            int currentNumber = 0;
            int factorialSum = 0;

            while (number != 0)
            {
                currentNumber = number % 10; // взимаме последната цифра от числото. напр. от 145 => 5
                number /= 10; // премахваме числото (5) от общия сбор(145), за да можем да му вземем факториела от 145 остава 14

                int factorial = 1; // слагаме го на 1, защото ще умножаваме всяко число по него => не може да е 0

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i; //взимаме факториела на числото
                }
                factorialSum += factorial;
            }
            string result = string.Empty;
            if (input == factorialSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            Console.WriteLine(result);
        }
    }
}
