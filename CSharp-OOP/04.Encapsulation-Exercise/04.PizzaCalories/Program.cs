using System;

namespace _04.PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pizzaName = Console.ReadLine().Split()[1];
            //Сплитваме по спейс и след това взимаме втория елемент[1];

            var doughData = Console.ReadLine().Split();

            var flourType = doughData[1];
            var bakingTechnique = doughData[2];
            var weight = int.Parse(doughData[3]);

            try
            {
                var dough = new Dough(flourType, bakingTechnique, weight);
                var pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    var line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }

                    var parts = line.Split();

                    var toppingName = parts[1];
                    var toppingWeight = int.Parse(parts[2]);

                    var topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
            }
            catch (Exception ex)
            when (ex is ArgumentException || ex is InvalidOperationException)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
