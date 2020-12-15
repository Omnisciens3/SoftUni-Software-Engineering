using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rent = 0;
            double discount = 0;
            double discountForEven = 0;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else
            {
                rent = 2600;
            }
            if (fishermen <= 6)
            {
                discount = rent * 0.10;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = rent * 0.15;
            }
            else
            {
                discount = rent * 0.25;
            }
            double totalPrice = rent - discount;
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                discountForEven = totalPrice * 0.05;
            }
            double finalPrice = totalPrice - discountForEven;
            
            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
