using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
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

            while (command != "End")
            {
                string[] currentCommand = command.Split();

                if (currentCommand[0] == "Add")
                {
                    integers.Add(int.Parse(currentCommand[1]));
                }
                else if (currentCommand[0] == "Insert")
                {
                    int index = int.Parse(currentCommand[2]);

                    if (IsNotAValidIndex(index, integers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.Insert(index, int.Parse(currentCommand[1]));
                    }
                    
                }
                else if (currentCommand[0] == "Remove")
                {
                    int index = int.Parse(currentCommand[1]);

                    if (IsNotAValidIndex(index, integers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.RemoveAt(index);
                    }
                    
                }
                else if (currentCommand[1] == "left")
                {
                    int rotation = int.Parse(currentCommand[2]);

                    for (int i = 0; i < rotation; i++)
                    {
                        int firstElement = integers[0];

                        for (int j = 0; j < integers.Count - 1; j++)
                        {
                            integers[j] = integers[j + 1]; 
                        }

                        integers[integers.Count - 1] = firstElement;
                    }
                }
                else if (currentCommand[1] == "right")
                {
                    int rotation = int.Parse(currentCommand[2]);

                    for (int i = 0; i < rotation; i++)
                    {
                        int lastElement = integers[integers.Count - 1];

                        for (int j = integers.Count - 1; j > 0; j--)
                        {
                            integers[j] = integers[j - 1];
                        }

                        integers[0] = lastElement;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', integers));
        }

        public static bool IsNotAValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}
