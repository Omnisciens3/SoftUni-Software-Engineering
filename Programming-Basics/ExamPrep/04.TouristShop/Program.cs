using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            double currentMoney = budget;
            double countOfProducts = 0;
            double moneySpent = 0;

            while (product != "Stop")
            {
                double priceForProduct = double.Parse(Console.ReadLine());
                countOfProducts++;
                if (countOfProducts % 3 == 0)
                {
                    priceForProduct /= 2;
                }
                if (currentMoney < priceForProduct)
                {
                    double moneyNeeded = priceForProduct - currentMoney;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    Environment.Exit(0);
                }
                currentMoney -= priceForProduct;
                moneySpent += priceForProduct;
                product = Console.ReadLine();
            }
            Console.WriteLine($"You bought {countOfProducts} products for {moneySpent:f2} leva.");
        }
    }
}
