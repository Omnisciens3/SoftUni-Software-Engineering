using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double veggieMenu = 8.15;
            double priceForDelivery = 2.50;

            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfVeggieMenus = int.Parse(Console.ReadLine());

            double totalPrice = numberOfChickenMenus * chickenMenu + numberOfFishMenus * fishMenu + numberOfVeggieMenus * veggieMenu;
            double priceForDessert = totalPrice * 0.20;
            double finalTotalPrice = totalPrice + priceForDessert + priceForDelivery;

            Console.WriteLine($"Total: {finalTotalPrice:f2}");
        }
    }
}
