using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string typeOfClothing = input[1];
                string[] differentTypes = typeOfClothing.Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in differentTypes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }

                    wardrobe[color][cloth]++;
                }
            }

            string[] needed = Console.ReadLine().Split();
            string neededColor = needed[0];
            string neededClothing = needed[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                if (wardrobe.ContainsKey(neededColor) && neededColor == color.Key)
                {
                    foreach (var clothing in color.Value)
                    {
                        if (wardrobe[neededColor].ContainsKey(neededClothing) && neededClothing == clothing.Key)
                        {
                            Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var clothing in color.Value)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
