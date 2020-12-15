using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                char firstLetter = current[0];
                char lastLetter = current[current.Length - 1];

                double number = double.Parse(current.Substring(1, current.Length - 2)); //индексът от който започваме е 1, защото знаем, че на нулевата позиция ни е първата започваща буква. А индексът на който завършваме е current.Lenght - 2, защото знаем, че на последна позиция (current.Lenght - 1) ни е последната буква, затова с current.Lenght - 2 взимаме индексът на който трябва да завършим.

                int firstElementIndex = alphabet.IndexOf(char.ToUpper(firstLetter)); // ToUpper, защото сме си задали азбуката в главни букви.
                int secondElementIndex = alphabet.IndexOf(char.ToUpper(lastLetter));

                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    number = number / (firstElementIndex + 1);
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }

                if ((int)lastLetter >=65 && (int)lastLetter <=90 )
                {
                    number = number - (secondElementIndex + 1);
                }
                else
                {
                    number = number + (secondElementIndex + 1);
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
