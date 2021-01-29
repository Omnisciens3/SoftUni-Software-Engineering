using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                result[i] = $"Line {i + 1}: {line} ({CountOfLetters(line)})({CountOfPunctuationMarks(line)})";
            }

            File.WriteAllLines("../../../output.txt", result);
        }

        static int CountOfLetters(string line)
        {
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }

            return counter;
        }

        static int CountOfPunctuationMarks(string line)
        {
            char[] punctuationMarks = { '-', ',', '.', '!', '?', '\'', ':', ';' };

            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (punctuationMarks.Contains(currentSymbol))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
