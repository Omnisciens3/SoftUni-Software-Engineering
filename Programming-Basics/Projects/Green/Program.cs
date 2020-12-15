using System;

namespace Green
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 7.61;
            double squareMeters = double.Parse(Console.ReadLine());
            double discount = 0.18;
            double fullPrice = price * squareMeters;
            double priceAfterDicsount = fullPrice * discount;
            double finalPrice = fullPrice - priceAfterDicsount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {priceAfterDicsount}");

        }
    }
}
