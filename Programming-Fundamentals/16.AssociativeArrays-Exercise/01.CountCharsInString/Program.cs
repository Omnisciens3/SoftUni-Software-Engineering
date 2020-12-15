using System;
using System.Collections.Generic;

namespace _01.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurrances = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!occurrances.ContainsKey(letter))
                    {
                        occurrances.Add(letter, 0);
                    }

                    occurrances[letter]++;
                }
            }

            foreach (var c in occurrances)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
