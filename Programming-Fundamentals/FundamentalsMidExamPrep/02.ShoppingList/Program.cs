using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                                            .Split('!', StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] currentGrocery = input.Split();
                string command = currentGrocery[0];
                string item = currentGrocery[1];

                switch (command)
                {
                    case "Urgent":

                        if (!groceries.Contains(item))
                        {
                            groceries.Insert(0, item);
                        }
                        break;

                    case "Unnecessary":
                        groceries.Remove(item);
                        break;

                    case "Correct":
                        string newItem = currentGrocery[2];
                        int index = groceries.IndexOf(item);

                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Insert(index, newItem);
                        }

                        break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
