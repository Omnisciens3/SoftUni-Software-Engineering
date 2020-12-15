using System;

namespace _01.FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Translate":
                        string character = tokens[1];
                        string replacement = tokens[2];

                        text = text.Replace(character, replacement);

                        Console.WriteLine(text);
                        break;
                        case "Includes":
                        string includes = tokens[1];
                        if (text.Contains(includes))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                        case "Start":
                        string[] cmdArgs = text.Split();
                        string start = cmdArgs[0];
                        string compare = tokens[1];
                        if (start == compare)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                        case "Lowercase":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                        case "FindIndex":
                        string ch = tokens[1];
                        Console.WriteLine(text.LastIndexOf(ch));
                        break;
                        case "Remove":
                        int startIndex = int.Parse(tokens[1]);
                        int count = int.Parse(tokens[2]);
                        text = text.Remove(startIndex, count);
                        Console.WriteLine(text);
                        break;

                }


                command = Console.ReadLine();
            }
        }
    }
}
