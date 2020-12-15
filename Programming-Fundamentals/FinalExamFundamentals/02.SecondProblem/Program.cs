using System;
using System.Text.RegularExpressions;

namespace _02.SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})(\1):\s\[(?<firstNum>[\d]+)\]\|\[(?<secondNum>[\d]+)\]\|\[(?<thirdNum>[\d]+)\]\|$";
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    int firstNum = int.Parse(match.Groups["firstNum"].Value);
                    int secondNum = int.Parse(match.Groups["secondNum"].Value);
                    int thirdNum = int.Parse(match.Groups["thirdNum"].Value);

                    char firstChar = Convert.ToChar(firstNum);
                    char secondChar = Convert.ToChar(secondNum);
                    char thirdChar = Convert.ToChar(thirdNum);

                    string tag = match.Groups["tag"].Value;
                    Console.WriteLine($"{tag}: {firstChar}{secondChar}{thirdChar}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
