using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] tokens = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "Contains":
                        string substring = tokens[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        string action = tokens[1];
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        string firstPart = activationKey.Substring(0, startIndex);
                        string secondPart = activationKey.Substring(startIndex, endIndex - startIndex);
                        string thirdPart = activationKey.Substring(endIndex);

                        if (action == "Upper")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }

                        activationKey = firstPart + secondPart + thirdPart;
                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);

                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
