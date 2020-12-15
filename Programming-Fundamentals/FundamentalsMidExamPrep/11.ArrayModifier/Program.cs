using System;
using System.Linq;

namespace _11.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                string action = cmdArgs[0];

                if (action == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);
                    int newPlace = array[index1];

                    array[index1] = array[index2];
                    array[index2] = newPlace;
                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    array[index1] = array[index1] * array[index2];
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
