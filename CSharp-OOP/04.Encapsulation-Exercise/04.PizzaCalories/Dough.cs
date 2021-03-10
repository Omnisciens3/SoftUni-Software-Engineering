using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        private const string InvalidDoughExeptionMessage = "Invalid type of dough.";

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }


        public string FlourType 
        {
            get => flourType;
            private set
            {
                var valueAsLower = value.ToLower();

                if (valueAsLower != "white" && valueAsLower != "wholegrain")
                {
                    throw new ArgumentException(InvalidDoughExeptionMessage);
                }

                flourType = value;
            }
        }

        public string BakingTechnique 
        {
            get => bakingTechnique;
            private set
            {
                var valueAsLower = value.ToLower();

                if (valueAsLower != "chewy" && 
                    valueAsLower != "crispy" && 
                    valueAsLower != "homemade")
                {
                    throw new ArgumentException(InvalidDoughExeptionMessage);
                }

                bakingTechnique = value;
            } 
        }

        public int Weight 
        {
            get => weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(MinWeight, MaxWeight, value, $"Dough weight should be in the range [{MinWeight}..{MaxWeight}]");

                weight = value;
            }
        }

        public double GetCalories()
        {
            var flourTypeModifier = GetTypeModifier();
            var bakingTechniqueModifier = GetBakingTechniqueModifier();

            return Weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetBakingTechniqueModifier()
        {
            var bakingTechniqueLower = BakingTechnique.ToLower();

            if (bakingTechniqueLower == "crispy")
            {
                return 0.9;
            }

            if (bakingTechniqueLower == "chewy")
            {
                return 1.1;
            }

            return 1;
        }

        private double GetTypeModifier()
        {
            var flourTypeToLower = FlourType.ToLower();
            if (flourTypeToLower == "white")
            {
                return 1.5;
            }

            return 1;
        }
    }
}
