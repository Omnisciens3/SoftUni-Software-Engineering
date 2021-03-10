using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public static class Validator
    {
        public static void ThrowIfNumberIsNotInRange(int min, int max, int number, string exeptionMessage)
        {
            if (number < min || number > max)
            {
                throw new ArgumentException(exeptionMessage);
            }
        }

        public static void ThrowIfValueIsNotAllowed(HashSet<string> allowedValues, string value, string exceptionMessage)
        {
            if (!allowedValues.Contains(value))
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
