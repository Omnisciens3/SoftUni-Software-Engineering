using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SugarCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sugarCubes = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();

            string input = Console.ReadLine();

            while (input != "Mort")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                int value = int.Parse(cmdArgs[1]);

                switch (command)
                {
                    case "Add":
                        sugarCubes.Add(value);
                        break;
                    case "Remove":
                        sugarCubes.Remove(value);
                        break;
                    case "Replace":
                        int replacement = int.Parse(cmdArgs[2]);
                        int index = sugarCubes.IndexOf(value);
                        sugarCubes.Remove(value);
                        sugarCubes.Insert(index, replacement);
                        break;
                    case "Collapse":
                        sugarCubes.RemoveAll(x => x < value);
                        break;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', sugarCubes));
        }
    }
}
