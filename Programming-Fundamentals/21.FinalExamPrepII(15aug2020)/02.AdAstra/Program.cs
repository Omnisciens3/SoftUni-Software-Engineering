using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)(?<item>[A-Za-z\s]+)\1(?<date>[0-9]{2}/[0-9]{2}/[0-9]{2})\1(?<calories>\d{3,})\1";
            //string pattern2 = @"(#|\|)(?<name>[A-Za-z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<cal>[0-9]{3,})\1";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            var calories = matches
                                  .Select(x => x.Groups["calories"])
                                  .Select(x => int.Parse(x.Value))
                                  .ToList()
                                  .Sum();

            int days = calories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            //"Item: {item name}, Best before: {expiration date}, Nutrition: {calories}"

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
