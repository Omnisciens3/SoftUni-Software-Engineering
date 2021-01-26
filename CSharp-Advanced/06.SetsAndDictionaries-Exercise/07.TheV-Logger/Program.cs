using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] input = command.Split();
                string vlogger = input[0];
                string followed = input[2];

                if (input.Length > 3)
                {
                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                        vloggers[vlogger].Add("followers", new SortedSet<string>());
                        vloggers[vlogger].Add("following", new SortedSet<string>());
                    }
                }
                else
                {
                    if (vloggers.ContainsKey(vlogger) && vloggers.ContainsKey(followed) && vlogger != followed)
                    {
                        vloggers[vlogger]["following"].Add(followed);
                        vloggers[followed]["followers"].Add(vlogger);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 1;
            //KeyValuePair<string, Dictionary<string, SortedSet<string>>> = var --> във foreach-a долу
            foreach (var vlogger in vloggers.OrderByDescending(v => v.Value["followers"].Count)
                                            .ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (string follower in vlogger.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}

