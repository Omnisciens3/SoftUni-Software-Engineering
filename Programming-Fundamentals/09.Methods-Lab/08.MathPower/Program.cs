using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            NumberToPower(number, power);
        }

        private static void NumberToPower(double number, int power)
        {
            double result = Math.Pow(number, power);
            Console.WriteLine(result);
        }
    }
}
