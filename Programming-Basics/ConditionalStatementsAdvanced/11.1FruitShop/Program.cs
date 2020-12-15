using System;

namespace _11._2_Fruit_Shop
{
    class Program
    {

        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        double totalPrice = quantity * price;
                        Console.WriteLine($"{totalPrice:F2}");
                        break;
                    case "apple":
                        price = 1.20;
                        double totalPriceApple = quantity * price;
                        Console.WriteLine($"{totalPriceApple:F2}");
                        break;
                    case "orange":
                        price = 0.85;
                        double totalPriceOrange = quantity * price;
                        Console.WriteLine($"{totalPriceOrange:F2}");
                        break;
                    case "grapefruit":
                        price = 1.45;
                        double totalPriceGrapefruit = quantity * price;
                        Console.WriteLine($"{totalPriceGrapefruit:F2}");
                        break;
                    case "kiwi":
                        price = 2.70;
                        double totalPriceKiwi = quantity * price;
                        Console.WriteLine($"{totalPriceKiwi:F2}");
                        break;
                    case "pineapple":
                        price = 5.50;
                        double totalPricePineapple = quantity * price;
                        Console.WriteLine($"{totalPricePineapple:F2}");
                        break;
                    case "grapes":
                        price = 3.85;
                        double totalPriceGrapes = quantity * price;
                        Console.WriteLine($"{totalPriceGrapes:F2}");

                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }


            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        double totalPrice = quantity * price;
                        Console.WriteLine($"{totalPrice:F2}");
                        break;
                    case "apple":
                        price = 1.25;
                        double totalPriceApple = quantity * price;
                        Console.WriteLine($"{totalPriceApple:F2}");
                        break;
                    case "orange":
                        price = 0.90;
                        double totalPriceOrange = quantity * price;
                        Console.WriteLine($"{totalPriceOrange:F2}");
                        break;
                    case "grapefruit":
                        price = 1.60;
                        double totalPriceGrapefruit = quantity * price;
                        Console.WriteLine($"{totalPriceGrapefruit:F2}");
                        break;
                    case "kiwi":
                        price = 3.00;
                        double totalPriceKiwi = quantity * price;
                        Console.WriteLine($"{totalPriceKiwi:F2}");
                        break;
                    case "pineapple":
                        price = 5.60;
                        double totalPricePineapple = quantity * price;
                        Console.WriteLine($"{totalPricePineapple:F2}");
                        break;
                    case "grapes":
                        price = 4.20;
                        double totalPriceGrapes = quantity * price;
                        Console.WriteLine($"{totalPriceGrapes:F2}");

                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
