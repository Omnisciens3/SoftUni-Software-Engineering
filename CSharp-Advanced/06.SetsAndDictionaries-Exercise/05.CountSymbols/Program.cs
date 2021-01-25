using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> occurances = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurances.ContainsKey(input[i]))
                {
                    occurances.Add(input[i], 0);
                }

                occurances[input[i]]++;
            }

            foreach (var symbol in occurances.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
