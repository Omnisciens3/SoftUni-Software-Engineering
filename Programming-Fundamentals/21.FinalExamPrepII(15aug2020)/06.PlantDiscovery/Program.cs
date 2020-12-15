using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string name = input[0];
                int rarity = int.Parse(input[1]);
                int rating = 0;
                if (plants.ContainsKey(name))
                {
                    plants[name][0] = rarity;
                    continue;
                }
                plants[name] = new List<double>() { rarity, rating };
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] cmdArg = command.Split(": ");
                string cmnd = cmdArg[0];
                string PQ = cmdArg[1];
                string[] left = PQ.Split(" - ");
                string plant = left[0];
                

                switch (cmnd)
                {
                    case "Rate":
                        int currRating = int.Parse(left[1]);
                        plants[plant][1] += currRating;
                        break;

                        case "Update":
                        int currRarity = int.Parse(left[1]);
                        plants[plant][0] = currRarity;
                        break;

                        case "Reset":
                        plants[plant][1] = 0;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

                command = Console.ReadLine();
            }

            //foreach (var item in plants)
            //{
            //    if (item.Value.Count == 0)
            //    {
            //        continue;
            //    }
                
            //    plants[item.Key][1] = item.Value.Average();
            //}
            Console.WriteLine("Plants for the exhibition:");
           
            foreach (var plant in plants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }
    }
}
