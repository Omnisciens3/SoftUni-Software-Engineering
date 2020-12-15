using System;

namespace _01.TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceInUsdForProcessor = double.Parse(Console.ReadLine());
            double priceInUsdForVideoCard = double.Parse(Console.ReadLine());
            double priceInUsdForRam = double.Parse(Console.ReadLine());
            int numberOfRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double usdRate = 1.57;

            double moneyForProcessor = priceInUsdForProcessor * usdRate;
            double moneyForVideoCard = priceInUsdForVideoCard * usdRate;
            double moneyForRam = priceInUsdForRam * usdRate * numberOfRam;

            moneyForProcessor -= moneyForProcessor * discount;
            moneyForVideoCard -= moneyForVideoCard * discount;

            double totalMoneyNeeded = moneyForProcessor + moneyForVideoCard + moneyForRam;

            Console.WriteLine($"Money needed - {totalMoneyNeeded:f2} leva.");
        }
    }
}
