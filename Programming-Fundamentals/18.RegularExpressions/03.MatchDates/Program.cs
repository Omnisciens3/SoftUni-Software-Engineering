using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b"; // слагаме backreference на capturing group-a за delimiter на \1, вместо на \2 (както би трябвало да е), защото при С# backreferences don’t count named capture groups for backreferences.
            string input = Console.ReadLine();

            var output = Regex.Matches(input, pattern);

            foreach (Match date in output)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            
        }
    }
}
