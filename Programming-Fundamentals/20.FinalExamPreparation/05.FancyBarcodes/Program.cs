using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _05.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            string productGroupPattern = @"\d";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex matches = new Regex(pattern);

                if (matches.IsMatch(input))
                {
                    Regex pGMatch = new Regex(productGroupPattern);

                    var productGroup = pGMatch.Matches(input);
                    List<string> result = new List<string>();

                    foreach (Match item in productGroup)
                    {
                        result.Add(item.Value);
                    }
                    if (pGMatch.IsMatch(input))
                    {
                        Console.Write($"Product group: ");
                        foreach (var output in result)
                        {
                            Console.Write(output);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
