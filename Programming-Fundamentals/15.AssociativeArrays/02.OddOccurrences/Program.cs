using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> oddOccurances = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string wordsInLower = word.ToLower();

                if (oddOccurances.ContainsKey(wordsInLower))
                {
                    oddOccurances[wordsInLower]++;
                }
                else
                {
                    oddOccurances.Add(wordsInLower, 1);
                }
            }

            foreach (var odd in oddOccurances)
            {
                if (odd.Value % 2 != 0)
                {
                    Console.Write(odd.Key + " ");
                }
            }

        }
    }
}
