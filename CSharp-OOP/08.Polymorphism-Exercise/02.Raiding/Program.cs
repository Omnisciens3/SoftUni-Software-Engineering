using System;
using System.Collections.Generic;

namespace _02.Raiding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            while (heroes.Count < n)
            {
                string name = Console.ReadLine();
                string race = Console.ReadLine();

                BaseHero hero = CreateHero(race, name);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                heroes.Add(hero);
            }

            int bossHealthPoints = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());

                bossHealthPoints -= hero.Power;
            }

            if (bossHealthPoints <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string race, string name)
        {
            BaseHero hero = null;

            if (race == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if (race == nameof(Warrior))
            {
                hero = new Warrior(name);
            }
            else if (race == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (race == nameof(Rogue))
            {
                hero = new Rogue(name);
            }

            return hero;
        }
    }
}
