using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            double totalMoneyStudio = 0;
            double totalMoneyApartment = 0;

            switch (month)
            {
                case "May":
                    studio = 50;
                    apartment = 65;
                    totalMoneyStudio = nights * studio;
                    totalMoneyApartment = nights * apartment;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                        totalMoneyApartment -= totalMoneyApartment * 0.10;
                        
                    }
                    else if (nights > 7)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    break;
                case "October":
                    studio = 50;
                    apartment = 65;
                    totalMoneyStudio = nights * studio;
                    totalMoneyApartment = nights * apartment;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                        totalMoneyApartment -= totalMoneyApartment * 0.10;
                        
                    }
                    else if (nights > 7)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    break;
                case "June":
                    studio = 75.20;
                    apartment = 68.70;
                    totalMoneyStudio = nights * studio;
                    totalMoneyApartment = nights * apartment;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;
                        totalMoneyApartment -= totalMoneyApartment * 0.10;
                    }
                    break;
                case "September":
                    studio = 75.20;
                    apartment = 68.70;
                    totalMoneyStudio = nights * studio;
                    totalMoneyApartment = nights * apartment;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;
                        totalMoneyApartment -= totalMoneyApartment * 0.10;
                    }
                    break;
                case "July":
                    studio = 76;
                    apartment = 77;
                    totalMoneyStudio = nights * studio;
                    totalMoneyApartment = nights * apartment;
                    if (nights > 14)
                    {
                        totalMoneyApartment -= totalMoneyApartment * 0.10;
                    }
                    break;
                case "August":
                    studio = 76;
                    apartment = 77;
                    totalMoneyStudio = nights * studio;
                    totalMoneyApartment = nights * apartment;
                    if (nights > 14)
                    {
                        totalMoneyApartment -= totalMoneyApartment * 0.10;
                    }
                    break;


            }

            Console.WriteLine($"Apartment: {totalMoneyApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyStudio:f2} lv.");

        }

    }
}

