using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //string regex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            //string input = Console.ReadLine();

            //Regex matches = new Regex(regex);
            //MatchCollection output = matches.Matches(input);

            //Console.WriteLine(string.Join(' ', output));

            string regex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection output = Regex.Matches(input, regex);

            Console.WriteLine(string.Join(' ', output));
        }
    }
}
