using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            // liquids - queue
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
             
            //ingredients - stack 
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int countOfBreads = 0;
            int countOfCakes = 0;
            int countOfPastry = 0;
            int countOfPie = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int sum = 0;
                int liquidValue = liquids.Peek();
                int ingredientValue = ingredients.Peek();

                sum += liquidValue + ingredientValue;

                if (sum == 25)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    countOfBreads++;
                }
                else if (sum == 50)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    countOfCakes++;
                }
                else if (sum == 75)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    countOfPastry++;
                }
                else if (sum == 100)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    countOfPie++;
                }
                else
                {
                    liquids.Dequeue();
                    int ingredient = ingredients.Pop() + 3;
                    ingredients.Push(ingredient);

                }
            }

            if (countOfBreads >= 1 && countOfCakes >= 1 && countOfPastry >= 1 && countOfPie >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            Console.WriteLine($"Bread: {countOfBreads}");
            Console.WriteLine($"Cake: {countOfCakes}");
            Console.WriteLine($"Fruit Pie: {countOfPie}");
            Console.WriteLine($"Pastry: {countOfPastry}");
        }
    }
}
