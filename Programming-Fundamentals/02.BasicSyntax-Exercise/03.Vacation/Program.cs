using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            //            Friday  Saturday    Sunday
            //Students    8.45      9.80       10.46
            //Business    10.90     15.60       16
            //Regular      15        20        22.50

            double price = 0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                        case "Saturday":
                        price = 9.80;
                        break;
                        case "Sunday":
                        price = 10.46;
                        break;
                }
                double totalPrice = numOfPeople * price;
                if (numOfPeople >= 30)
                {
                    totalPrice -= totalPrice * 0.15; // totalPrice *= 0.85;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (typeOfGroup == "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }
                double totalPrice = numOfPeople * price;
                if (numOfPeople >= 100)
                {
                    totalPrice = (numOfPeople - 10) * price;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }
                double totalPrice = numOfPeople * price;
                if (numOfPeople >= 10 && numOfPeople <=20)
                {
                    totalPrice -= totalPrice * 0.05; // totalPrice *= 0.95;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
        }
    }
}
