using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mirrorWords = new List<string>();

            string text = Console.ReadLine();

            Regex regex = new Regex(@"(@|#)([A-Za-z]{3,})(\1){2}([A-Za-z]{3,})(\1)");

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                string firstWord = item.Groups[2].Value;
                string secondWord = ReversedString(item.Groups[4].Value);

                if (firstWord == secondWord)
                {
                    mirrorWords.Add(firstWord + " <=> " + item.Groups[4].Value);
                }

            }

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }

            
        }

        public static string ReversedString(string strVariable)
        {
            return new string(strVariable.Reverse().ToArray());
        }
    }
}
