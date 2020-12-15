using System;

namespace _03.NewHouse
{
    class Program
    {

        static  double rosesPrice = 5;
        static double daliusPrice = 3.80;
        static double tulipPrice = 2.80;
        static double narcissusPrice = 3;
        static double gladiolusPrice = 2.50;
        static void Main(string[] args)
        {
            
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            if (typeOfFlowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    totalPrice -= numberOfFlowers * rosesPrice * 0.10;
                }

                totalPrice += numberOfFlowers * rosesPrice;
                
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    totalPrice -= numberOfFlowers * daliusPrice * 0.15;
                }
                totalPrice += numberOfFlowers * daliusPrice;
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    totalPrice -= numberOfFlowers * tulipPrice * 0.15;
                }
                totalPrice += numberOfFlowers * tulipPrice;
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    totalPrice += numberOfFlowers * narcissusPrice * 0.15;
                }
                totalPrice += numberOfFlowers * narcissusPrice;
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    totalPrice += numberOfFlowers * gladiolusPrice * 0.20;
                }
                totalPrice += numberOfFlowers * gladiolusPrice;
            }
            double moneyLeft = budget - totalPrice;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.") ;
            }
            
        }
    }
}
