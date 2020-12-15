using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0.0;

            while (input != "NoMoreMoney")
            {
                double savedMoney = double.Parse(input);
                if (savedMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalMoney += savedMoney;
                Console.WriteLine($"Increase: {savedMoney:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
