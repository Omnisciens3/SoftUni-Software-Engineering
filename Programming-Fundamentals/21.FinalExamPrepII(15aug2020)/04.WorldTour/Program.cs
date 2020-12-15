using System;

namespace _04.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] cmdArg = command.Split(":");
                string cmnd = cmdArg[0];

                switch (cmnd)
                {
                    case "Add Stop":

                        int index = int.Parse(cmdArg[1]);
                        string add = cmdArg[2];

                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, add);
                        }
                        Console.WriteLine(stops);
                        break;

                        case "Remove Stop":

                        int startIndex = int.Parse(cmdArg[1]);
                        int endIndex = int.Parse(cmdArg[2]);
                        int count = endIndex - startIndex;
                        if (startIndex >= 0 && endIndex < stops.Length )
                        {
                            stops = stops.Remove(startIndex, count + 1);
                        }
                        Console.WriteLine(stops);
                        break;

                        case "Switch":

                        string oldString = cmdArg[1];
                        string newString = cmdArg[2];

                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                        }
                        Console.WriteLine(stops);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
