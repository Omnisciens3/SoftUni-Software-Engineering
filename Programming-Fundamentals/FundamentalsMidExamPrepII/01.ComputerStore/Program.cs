using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 0;

            while (input != "regular" && input != "special")
            {
                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                totalPrice += price;

                input = Console.ReadLine();
            }

            taxes += totalPrice * 0.2;
            double totalPriceWithTaxes = totalPrice + taxes;

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                Environment.Exit(0);
            }

            if (input == "special")
            {
                totalPriceWithTaxes -= totalPriceWithTaxes * 0.1;
                Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {totalPrice:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {totalPriceWithTaxes:f2}$");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {totalPrice:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {totalPriceWithTaxes:f2}$");
            }
        }
    }
}
