using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractDuration = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int monthsToPay = int.Parse(Console.ReadLine());

            double price = 0;

            if (contractDuration == "one")
            {
                switch (typeOfContract)
                {
                    case "Small":
                        price = 9.98;
                        break;
                        case "Middle":
                        price = 18.99;
                        break;
                        case "Large":
                        price = 25.98;
                        break;
                        case "ExtraLarge":
                        price = 35.99;
                        break;
                }
            }
            else
            {
                switch (typeOfContract)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                }
            }
            double priceForInternet = 0;
            if (mobileInternet == "yes")
            {
                if (price <= 10)
                {
                    priceForInternet = 5.50;
                }
                else if (price <=30)
                {
                    priceForInternet = 4.35;
                }
                else
                {
                    priceForInternet = 3.85;
                }
            }
            double finalPrice = (price + priceForInternet) * monthsToPay;
            if (contractDuration == "two")
            {
                finalPrice -= finalPrice * 0.0375;
            }
            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
