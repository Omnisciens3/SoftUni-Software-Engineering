using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double pricePerGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double discount = 0;
            double cakePrice = budget * 0.10;

            if (guests >= 10 && guests <= 15)
            {
                discount = pricePerGuest * 0.15;
            }
            else if (guests > 15 && guests <= 20)
            {
                discount = pricePerGuest * 0.20;
            }
            else if (guests > 20)
            {
                discount = pricePerGuest * 0.25;
            }
            else
            {

            }
            double totalPrice = guests * (pricePerGuest - discount) + cakePrice;
            if (budget > totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"No party! {moneyNeeded:f2} leva needed.");
            }
        }
    }
}
