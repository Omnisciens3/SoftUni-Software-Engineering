using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCards = Console.ReadLine()
                                              .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                
                switch (command)
                {
                    
                    case "Add":
                        string cardName = input[1];
                        if (listOfCards.Contains(cardName))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {
                            listOfCards.Add(cardName);
                            Console.WriteLine("Card successfully bought");
                        }
                        break;
                    case "Remove":
                        string cardName3 = input[1];
                        if (listOfCards.Contains(cardName3))
                        {
                            listOfCards.Remove(cardName3);
                            Console.WriteLine("Card successfully sold");
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                        }
                        break;
                    case "Remove At":
                        int index = int.Parse(input[1]);
                        if (index < 0 && index >= listOfCards.Count)
                        {
                            Console.WriteLine("Index out of range");
                            continue;
                        }
                        else
                        {
                            listOfCards.RemoveAt(index);
                            Console.WriteLine("Card successfully sold");
                        }
                        break;
                    case "Insert":
                        int index2 = int.Parse(input[1]);
                        string cardName2 = input[2];

                        if (index2 >= 0 && index2 < listOfCards.Count)
                        {
                            if (!listOfCards.Contains(cardName2))
                            {
                                listOfCards.Insert(index2, cardName2);
                                Console.WriteLine("Card successfully bought");
                            }
                            else
                            {
                                Console.WriteLine("Card is already bought");
                            }
                        }            
                        else
                        {
                            Console.WriteLine("Index out of range");
                            continue;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", listOfCards));
        }
    }
}
