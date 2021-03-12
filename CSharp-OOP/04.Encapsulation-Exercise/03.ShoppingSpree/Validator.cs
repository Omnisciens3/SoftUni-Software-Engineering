using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exceptionMsg)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exceptionMsg);
            }
        }

        public static void ThrowIfNumberIsNegative(decimal number, string exceptionMsg)
        {
            if (number < 0)
            {
                throw new ArgumentException(exceptionMsg);
            }
        }
    }
}
