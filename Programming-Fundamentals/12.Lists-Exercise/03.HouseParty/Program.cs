﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Length < 4)
                {
                    if (guestList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(command[0]);
                    }
                }
                else
                {
                    if (!guestList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    else
                    {
                        guestList.Remove(command[0]);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
