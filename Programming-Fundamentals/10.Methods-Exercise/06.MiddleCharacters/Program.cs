using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string output = GetMiddleCharFromEvenString(input);
                Console.WriteLine(output);
            }

            else
            {
                string oddOutput = GetMiddleCharFromOddString(input);
                Console.WriteLine(oddOutput);
            }
        }

        private static string GetMiddleCharFromOddString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1); 
            return chars;
        }

        private static string GetMiddleCharFromEvenString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2); //index - обозначава на кой индекс искаме да го разцепим, а                                                   двойката отзад показва колко charachter-а искаме да вземем.
            return chars;
        }
    }
}
