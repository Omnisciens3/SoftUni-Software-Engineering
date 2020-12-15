using System;

namespace _03.Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfHoursSpent = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            // Март до Май          Юни до Август
            //Ден 10.50 / ч        12.60 / ч
            //Нощ 8.4 / ч          10.20 / ч
            double price = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                switch (timeOfTheDay)
                {
                    case "day":
                        price = 10.50;
                        break;
                    case "night":
                        price = 8.4;
                        break;
                }
                if (numberOfPeople >= 4)
                {
                    price -= price * 0.10;
                }
                if (numberOfHoursSpent >= 5)
                {
                    price -= price * 0.50;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                switch (timeOfTheDay)
                {
                    case "day":
                        price = 12.60;
                        break;
                    case "night":
                        price = 10.20;
                        break;
                }
                if (numberOfPeople >= 4)
                {
                    price -= price * 0.10;
                }
                if (numberOfHoursSpent >= 5)
                {
                    price -= price * 0.50;
                }
            }
            double totalPrice = numberOfPeople * price * numberOfHoursSpent;
            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");
        }
    }
}
