using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> people = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();

            while (command != "Results")
            {
                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                string name = tokens[1];

                switch (cmd)
                {
                    case "Add":
                        int health = int.Parse(tokens[2]);
                        int energy = int.Parse(tokens[3]);
                        if (people.ContainsKey(name))
                        {
                            people[name][0] += health;
                        }
                        else
                        {
                            people.Add(name, new List<int>() { health, energy });
                        }
                        break;

                    case "Attack":
                        string defenderName = tokens[2];
                        int damage = int.Parse(tokens[3]);

                        if (people.ContainsKey(name) && people.ContainsKey(defenderName))
                        {
                            people[defenderName][0] -= damage;
                            people[name][1] -= 1;
                            if (people[defenderName][0] <= 0)
                            {
                                people.Remove(defenderName);
                                Console.WriteLine($"{defenderName} was disqualified!");
                            }
                            if (people[name][1] == 0)
                            {
                                people.Remove(name);
                                Console.WriteLine($"{name} was disqualified!");
                            }
                        }
                        
                        break;
                    case "Delete":

                        if (name == "All")
                        {
                            people.Clear();
                        }
                        else
                        {
                            people.Remove(name);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"People count: {people.Count}");

            foreach (var person in people.OrderByDescending(h => h.Value[0]).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }
    }
}
