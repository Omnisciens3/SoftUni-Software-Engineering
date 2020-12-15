using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\/{1}|\={1})(?<destination>[A-Z][A-Za-z]{2,})\1";

            string places = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(places);

            Console.WriteLine($"Destinations: {string.Join(", ", matches.Select(n => n.Groups[2]))}");
            Console.WriteLine($"Travel Points: {matches.Select(x => x.Groups[2]).Select(x=>x.Value.Length).ToList().Sum()}");
        }
    }
}
