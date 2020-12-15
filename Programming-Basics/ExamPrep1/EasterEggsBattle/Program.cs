using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            int numberOfEggsForP1 = int.Parse(Console.ReadLine());
            int numberOfEggsForP2 = int.Parse(Console.ReadLine());

            while (flag)
            {
                string command = Console.ReadLine();
                if (numberOfEggsForP1 == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {numberOfEggsForP2} eggs left.");
                    Environment.Exit(0);
                }
                else if (numberOfEggsForP2 == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {numberOfEggsForP1} eggs left.");
                    Environment.Exit(0);
                }
                
                if (command == "one")
                {
                    numberOfEggsForP2--;
                }
                else if (command == "two")
                {
                    numberOfEggsForP1--;
                }
                if (command == "End of battle")
                {
                    flag = false;
                }
            }
            Console.WriteLine($"Player one has {numberOfEggsForP1} eggs left.");
            Console.WriteLine($"Player two has {numberOfEggsForP2} eggs left.");
        }
    }
}
