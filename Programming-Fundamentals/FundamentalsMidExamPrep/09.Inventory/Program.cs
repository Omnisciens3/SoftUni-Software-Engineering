using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArgs = input.Split(" - ");
                string command = cmdArgs[0];
                string item = cmdArgs[1];

                switch (command)
                {
                    case "Collect":
                        if (!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }
                        break;
                    case "Drop":
                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                        }
                        break;
                    case "Combine Items":

                        string[] combineItems = item.Split(":");
                        string oldItem = combineItems[0];
                        string newItem = combineItems[1];

                        if (inventory.Contains(oldItem))
                        {
                            int index = inventory.IndexOf(oldItem);

                            inventory.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                            inventory.Add(item);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
