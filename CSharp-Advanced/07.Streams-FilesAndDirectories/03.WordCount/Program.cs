using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../words.txt"))
            {
                using (StreamReader readerTwo = new StreamReader("../../../text.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                    {
                        using (StreamWriter writerTwo = new StreamWriter("../../../outputTwo.txt"))
                        {
                            string textPath = "text.txt";
                            string wordsPath = "words.txt";

                            var textLines = File.ReadAllLines(textPath);
                            var words = File.ReadAllLines(wordsPath);

                            var wordsCount = new Dictionary<string, int>();

                            foreach (var word in words)
                            {
                                string lowercaseWord = word.ToLower();

                                if (!wordsCount.ContainsKey(lowercaseWord))
                                {
                                    wordsCount.Add(lowercaseWord, 0);
                                }
                            }

                            foreach (var line in textLines)
                            {
                                var currentLine = line
                                    .ToLower()
                                    .Split(new char[] { ' ', '-', ',', '!', '?', '.', '\'' });

                                foreach (var currentWord in currentLine)
                                {
                                    if (wordsCount.ContainsKey(currentWord))
                                    {
                                        wordsCount[currentWord]++;
                                    }
                                }
                            }

                            string actualResultPath = "output.txt";
                            string expectedResultPath = "outputTwo.txt";

                            foreach (var kvp in wordsCount)
                            {
                                File.AppendAllText(actualResultPath, $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
                            }

                            foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                            {
                                File.AppendAllText(expectedResultPath, $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
                            }
                        }
                    }
                }
            }
        }
    }
}
