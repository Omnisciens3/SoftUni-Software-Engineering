using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string first = input[0];
            string second = input[1];

            string longWord = first;
            string shortWord = second;

            if (first.Length < second.Length)
            {
                longWord = second;
                shortWord = first;
            }

            int result = 0;

            for (int i = 0; i < shortWord.Length; i++)
            {
                int multiply = shortWord[i] * longWord[i];
                result += multiply;
            }

            for (int i = shortWord.Length; i < longWord.Length; i++)
            {
                result += longWord[i];
            }

            Console.WriteLine(result);
        }
    }
}
