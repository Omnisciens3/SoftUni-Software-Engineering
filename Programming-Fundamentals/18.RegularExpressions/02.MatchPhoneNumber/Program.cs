using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+[359]+([-\s])[2]\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();

            var output = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
