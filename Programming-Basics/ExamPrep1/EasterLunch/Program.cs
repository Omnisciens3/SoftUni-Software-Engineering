using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBreads = int.Parse(Console.ReadLine());
            int numberOfEggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            //•	Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце

            double totalPrice = numberOfBreads * 3.20 + cookies * 5.40;
            double priceForEggs = numberOfEggs * 4.35;
            double priceForEggsColours = numberOfEggs * 12 * 0.15;
            double finalPrice = totalPrice + priceForEggsColours + priceForEggs;

            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}
