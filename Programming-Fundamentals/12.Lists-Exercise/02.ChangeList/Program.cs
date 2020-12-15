using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Delete")
                {
                    integers.RemoveAll(x => x == int.Parse(cmdArgs[1]));
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    integers.Insert(index, int.Parse(cmdArgs[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', integers));
        }
    }
}
