using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            VowelCounter(input);
        }

        private static void VowelCounter(string input) //ако искаме методът ни да е достъпен и от другите програми в дадения Solution трябва да го направим public, а не private.
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a' || currentChar == 'o' || currentChar == 'u' 
                                       || currentChar == 'i'|| currentChar == 'y' || currentChar == 'e')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
