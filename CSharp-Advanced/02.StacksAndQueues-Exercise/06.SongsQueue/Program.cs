using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < songs.Length; i++)
            {
                queue.Enqueue(songs[i]);
            }

            while (queue.Count > 0)
            {
                string[] cmdArgs = command.Split();
                string cmd = cmdArgs[0];
                
                switch (cmd)
                {
                    case "Play":
                        queue.Dequeue();
                        break;

                        case "Add":
                        string song = command.Substring(4);
                        
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;
                        case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;

                }
                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
