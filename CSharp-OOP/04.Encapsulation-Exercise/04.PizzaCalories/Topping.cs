using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get => name;
            private set
            {
                Validator.ThrowIfValueIsNotAllowed(
                    new HashSet<string> { "meat", "veggies", "cheese", "sauce" },
                    value.ToLower(),
                    $"Cannot place {value} on top of your pizza.");

                //горният метод върши работата на тези проверки и може да се замени навсякъде в кода, където има такива проверки.

                //var valueAsLower = value.ToLower();

                //if (valueAsLower != "meat" &&
                //    valueAsLower != "veggies" &&
                //    valueAsLower != "cheese" &&
                //    valueAsLower != "sauce")
                //{
                //    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                //}

                name = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(MinWeight, 
                                    MaxWeight, 
                                    value,
                                    $"{Name} weight should be in the range [{MinWeight}..{MaxWeight}].");

                weight = value; 
            }
        }

        public double GetCalories()
        {
            var modifier = GetModifier();

            return Weight * 2 * modifier;
        }

        private double GetModifier()
        {
            var nameLower = Name.ToLower();

            if (nameLower == "meat")
            {
                return 1.2;
            }

            if (nameLower == "veggies")
            {
                return 0.8;
            }

            if (nameLower == "cheese")
            {
                return 1.1;
            }

            return 0.9;
        }
    }
}
