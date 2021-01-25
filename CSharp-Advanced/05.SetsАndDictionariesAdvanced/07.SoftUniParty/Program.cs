using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "PARTY")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (i == 0)
                    {
                        if (char.IsDigit(command[i]))
                        {
                            vipGuests.Add(command); 
                        }
                        else
                        {
                            regularGuests.Add(command);
                        }
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "END")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (i == 0)
                    {
                        if (char.IsDigit(command[i]))
                        {
                            vipGuests.Remove(command);
                        }
                        else
                        {
                            regularGuests.Remove(command);
                        }
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
