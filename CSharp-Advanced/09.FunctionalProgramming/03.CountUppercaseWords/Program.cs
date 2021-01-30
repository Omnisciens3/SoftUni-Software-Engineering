using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //                              .Where(s => s[0] == s.ToUpper()[0])
            //                              .ToArray();

            //Console.WriteLine(string.Join("\n", input));

            Func<string, bool> filter = text => Char.IsUpper(text[0]);
            string text = Console.ReadLine();
            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(filter).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
