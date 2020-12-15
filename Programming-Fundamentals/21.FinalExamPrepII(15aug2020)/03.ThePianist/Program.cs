using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] initialPieces = Console.ReadLine().Split("|");
                string pieceName = initialPieces[0];
                string composer = initialPieces[1];
                string key = initialPieces[2];

                collection[pieceName] = new List<string>() { composer, key };
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] cmdArgs = command.Split("|");
                string cmnd = cmdArgs[0];
                string piece = cmdArgs[1];

                switch (cmnd)
                {
                    case "Add":
                        string composer = cmdArgs[2];
                        string key = cmdArgs[3];
                        if (!collection.ContainsKey(piece))
                        {
                            collection[piece] = new List<string>() { composer, key };
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;

                        case "Remove":

                        if (collection.ContainsKey(piece))
                        {
                            collection.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                        case "ChangeKey":

                        if (collection.ContainsKey(piece))
                        {
                            string newKey = cmdArgs[2];
                            collection[piece][1] = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                }
                command = Console.ReadLine();
            }

            foreach (var (piece, value) in collection.OrderBy(x => x.Key).ThenBy(x=>x.Value))
            {
                Console.WriteLine($"{piece} -> Composer: {value[0]}, Key: {value[1]}");
            }
        }
    }
}
