using System;
using System.Linq;
using System.Security;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSamples = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int count = 0;
            int bestCount = 0;
            int bestStartIndex = 0;
            int bestSum = 0;
            string bestSequence = string.Empty;
            int bestCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them!") // вместо да си взимаме инпута всеки път отвътре while loop-a
            {
                string currentSequence = input.Replace("!", ""); // replace-ва стария char "!" с празно място.
                string[] dnaParts = currentSequence.Split("0", StringSplitOptions.RemoveEmptyEntries);

                int counter = 0;
                int sum = 0;
                string bestSubSequence = string.Empty;
                count++;

                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > counter)
                    {
                        counter = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }

                int startIndex = currentSequence.IndexOf(bestSubSequence); // Този метод IndexOf ни дава индекса, от който започва най-добрата ДНК последователност.
                if (counter > bestCount || (counter == bestCount && startIndex < bestStartIndex) 
                                        || (counter == bestCount && startIndex == bestStartIndex && sum > bestSum)
                                        || count == 1)
                {
                    bestCount = counter;
                    bestSequence = currentSequence;
                    bestStartIndex = startIndex;
                    bestSum = sum;
                    bestCounter = count;
                }
            }
            char[] result = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}
