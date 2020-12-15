using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string cmnd = cmdArgs[0];

                switch (cmnd)
                {
                    case "InsertSpace":
                        int index = int.Parse(cmdArgs[1]);
                        concealedMessage = concealedMessage.Insert(index, " ");
                        Console.WriteLine(concealedMessage);
                        break;

                    case "Reverse":
                        string substring = cmdArgs[1];
                        string reversed = string.Empty;
                        if (concealedMessage.Contains(substring))
                        {
                            int indexOf = concealedMessage.IndexOf(substring);
                            concealedMessage = concealedMessage.Remove(indexOf, substring.Length);
                            //concealedMessage.Remove(concealedMessage.IndexOf(substring), substring.Length); - директно взимаме индекса без да създаваме нова променлива за индекс;
                            for (int i = substring.Length - 1; i >= 0; i--)
                            {
                                reversed += substring[i];
                            }
                            //var reversed = new string(substring.Reverse().ToArray()); - ривърсваме стринга без да използваме горният обратен фор цикъл;
                            concealedMessage += reversed;
                            Console.WriteLine(concealedMessage);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        string toBeReplaced = cmdArgs[1];
                        string replacement = cmdArgs[2];

                        concealedMessage = concealedMessage.Replace(toBeReplaced, replacement);
                        Console.WriteLine(concealedMessage);
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
