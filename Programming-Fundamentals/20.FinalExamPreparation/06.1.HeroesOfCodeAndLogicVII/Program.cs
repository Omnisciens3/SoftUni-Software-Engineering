using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._1.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                heroHP[heroName] = hp;
                heroMP[heroName] = mp;
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
                        string spellName = cmdArg[3];

                        if (heroMP[heroName] >= manaNeeded)
                        {
                            heroMP[heroName] -= manaNeeded;

                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMP[heroName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":

                        int damage = int.Parse(cmdArg[2]);
                        string attacker = cmdArg[3];
                        heroHP[heroName] -= damage;

                        if (heroHP[heroName] > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHP[heroName]} HP left!");
                        }
                        else
                        {
                            heroHP.Remove(heroName);
                            heroMP.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        int amount = int.Parse(cmdArg[2]);
                        int currentAmount = heroMP[heroName];
                        heroMP[heroName] += amount;

                        if (heroMP[heroName] > 200)
                        {
                            heroMP[heroName] = 200; 
                            Console.WriteLine($"{heroName} recharged for {200 - currentAmount} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        }
                        break;
                    case "Heal":
                        int heal = int.Parse(cmdArg[2]);
                        int currentHP = heroHP[heroName];
                        heroHP[heroName] += heal;

                        if (heroHP[heroName] > 100)
                        {
                            heroHP[heroName] = 100;
                            Console.WriteLine($"{heroName} healed for {100 - currentHP} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} healed for {heal} HP!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (var hero in heroHP.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{hero.Key}\n HP: {hero.Value}\n MP: {heroMP[hero.Key]}");
            }
        }
    }
}
