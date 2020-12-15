using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //Input

            double strawberriesPrice = double.Parse(Console.ReadLine());
            double quantityOfBananas = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfRaspberries = double.Parse(Console.ReadLine());
            double quantityOfStrawberries = double.Parse(Console.ReadLine());

            //Calc
            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - (0.4 * raspberriesPrice);
            double bananaPrice = raspberriesPrice - (0.8 * raspberriesPrice);
            double raspberriesSum = quantityOfRaspberries * raspberriesPrice;
            double orangesSum = quantityOfOranges * orangesPrice;
            double bananaSum = quantityOfBananas * bananaPrice;
            double strawberriesSum = strawberriesPrice * quantityOfStrawberries;
            
            double totalSum = raspberriesSum + orangesSum + bananaSum + strawberriesSum;
            //Output

            Console.WriteLine($"{totalSum:F2}");


        }
    }
}
