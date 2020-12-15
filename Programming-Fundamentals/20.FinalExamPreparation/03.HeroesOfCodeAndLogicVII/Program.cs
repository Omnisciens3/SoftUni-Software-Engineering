using System;
using System.Collections.Generic;

namespace _06.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<int, int> manaAndHp = new Dictionary<int, int>();
            Dictionary<string, Dictionary<int, int>> heroes = new Dictionary<string, Dictionary<int, int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                manaAndHp.Add(hp, mp);
                heroes.Add(name, manaAndHp);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split(" - ");
                string commanD = cmdArg[0];
                string heroName = cmdArg[1];

                switch (commanD)
                {
                    case "CastSpell":
                        int manaNeeded = int.Parse(cmdArg[2]);
                        if (heroes[heroName].Values(manaAndHp)
                        {

                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
