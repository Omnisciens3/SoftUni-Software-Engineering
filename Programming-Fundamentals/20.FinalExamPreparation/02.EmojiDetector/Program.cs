using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"\d";
            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";

            Regex numRegex = new Regex(numberPattern);
            Regex emojiRegex = new Regex(emojiPattern);

            string text = Console.ReadLine();

            long coolTreshold = 1;
            numRegex.Matches(text)
                .Select(m=>m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x=> coolTreshold *= x);

            var matches = emojiRegex.Matches(text);
            int totalEmojis = matches.Count;

            List<string> coolEmojis = new List<string>();

            foreach (Match match in matches)
            {
                long coolIndex = match.Value
                                        .Substring(2, match.Value.Length - 4)
                                        .ToCharArray()
                                        .Sum(x => (int)x);

                if (coolIndex > coolTreshold)
                {
                    coolEmojis.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
