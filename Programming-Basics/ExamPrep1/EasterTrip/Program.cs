using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            //Дестинация  21 - 23 март        24 - 27 март        28 - 31 март
            // Франция        30 лв.              35 лв.              40 лв.
            // Италия         28 лв.              32 лв.              39 лв.
            //Германия        32 лв.              37 лв.              43 лв.

            int price = 0;
            if (destination == "France")
            {
                switch (dates)
                {
                    case "21-23":
                        price = 30;
                        break;
                    case "24-27":
                        price = 35;
                        break;
                    case "28-31":
                        price = 40;
                        break;
                }
            }
            else if (destination == "Italy")
            {
                switch (dates)
                {
                    case "21-23":
                        price = 28;
                        break;
                    case "24-27":
                        price = 32;
                        break;
                    case "28-31":
                        price = 39;
                        break;
                }
            }
            else
            {
                switch (dates)
                {
                    case "21-23":
                        price = 32;
                        break;
                    case "24-27":
                        price = 37;
                        break;
                    case "28-31":
                        price = 43;
                        break;
                }
            }
            double totalPrice = numberOfNights * price;
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");
        }
    }
}
