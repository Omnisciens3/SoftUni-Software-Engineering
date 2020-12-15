using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerLitre = 2.10;
            double priceForGuide = 100;

            double budget = double.Parse(Console.ReadLine());
            double litresNeeded = double.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            double moneyForSafari = litresNeeded * pricePerLitre + priceForGuide;
            if (dayOfTheWeek == "Saturday")
            {
                moneyForSafari *= 0.90;
            }
            else
            {
                moneyForSafari *= 0.80;
            }
            if (budget > moneyForSafari)
            {
                double moneyLeft = budget - moneyForSafari;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv. ");
            }
            else
            {
                double moneyNeeded = moneyForSafari - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
    }
}
