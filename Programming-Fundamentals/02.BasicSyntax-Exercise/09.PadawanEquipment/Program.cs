using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOfALightSaber = double.Parse(Console.ReadLine());
            double priceForARobes = double.Parse(Console.ReadLine());
            double priceForABelt = double.Parse(Console.ReadLine());

            int numberOfLightSabers = numberOfStudents;
            int numberOfRobes = numberOfStudents;
            int numberOfBelts = numberOfStudents;

            double additionalLightSabres = numberOfLightSabers * 0.1;
            int numberOfFreeBelts = numberOfBelts / 6;

            double totalPrice = (numberOfLightSabers + Math.Ceiling(additionalLightSabres)) * priceOfALightSaber + numberOfRobes * priceForARobes + (numberOfBelts - numberOfFreeBelts) * priceForABelt;

            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}
