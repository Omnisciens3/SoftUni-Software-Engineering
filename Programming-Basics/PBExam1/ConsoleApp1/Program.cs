using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoinValue = 1168;
            double USD = 1.76;
            double CNY = 0.15 * USD;
            double EUR = 1.95;

            int numberOfBitcoins = int.Parse(Console.ReadLine());
            double numberOfCNY = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double result = (numberOfBitcoins * bitcoinValue + numberOfCNY * CNY) / EUR;
            double totalAmountBC = (result * comission) / 100;
            double totalAmountAC = result - totalAmountBC;
            Console.WriteLine($"{totalAmountAC:f2}");
        }
    }
}
