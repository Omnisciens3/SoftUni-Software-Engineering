using System;
using System.Collections.Generic;
using System.Linq;
namespace plantDisc2020
{
    class plantDisc2020
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, double>> plants = new Dictionary<string, Dictionary<string, double>>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = tokens[0].Trim();
                double rarity = double.Parse(tokens[1].Trim());
                if (plants.ContainsKey(plant))
                {
                    plants[plant]["rarity"] = rarity;
                }
                else
                {
                    plants.Add(plant, new Dictionary<string, double>());
                    plants[plant].Add("rarity", rarity);
                    //добавено
                    plants[plant].Add("rating", 0);
                }
            }

            string command = string.Empty;
            Dictionary<string, List<double>> ratingsStore = new Dictionary<string, List<double>>();
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] arguments = command.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string move = arguments[0].Trim();
                string plant = arguments[1].Trim();

                switch (move)
                {
                    case "Rate:":
                        double rating = double.Parse(arguments[2].Trim());
                        if (!plants.ContainsKey(plant))
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        if (!ratingsStore.ContainsKey(plant))
                        {
                            ratingsStore.Add(plant, new List<double>());
                            ratingsStore[plant].Add(rating);
                        }
                        else
                        {
                            ratingsStore[plant].Add(rating);
                        }



                        break;
                    case "Update:":

                        double rarity = double.Parse(arguments[2].Trim());
                        if (!plants.ContainsKey(plant))
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        plants[plant]["rarity"] = rarity;
                        break;
                    case "Reset:":
                        if (!plants.ContainsKey(plant))
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        ratingsStore[plant].RemoveAll(x => x != 0);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            foreach (var item in ratingsStore)
            {
                //добавено 
                if (item.Value.Count == 0) // проверяваме дали листа е е празен, защото ако е празен AVERAGE() ще гръмне :) 
                {
                    continue;
                }
                plants[item.Key]["rating"] = item.Value.Average();
                //няма нужда :) 
                //if (plants.ContainsKey(item.Key) && item.Value.Count != 0)
                //{
                //    plants[item.Key].Add("rating", item.Value.Average());
                //}
                //else
                //{
                //    if (!plants.ContainsKey("rating"))
                //    {
                //        plants[item.Key].Add("rating", 0);
                //    }
                //}
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x => x.Value["rarity"]).ThenByDescending(x => x.Value["rating"]))
            {

                Console.WriteLine($"- {item.Key}; Rarity: {item.Value["rarity"]}; Rating: {item.Value["rating"]:f2}");
            }
        }
    }
}