using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            data = new List<Hero>();
        }

        public int Count { get { return data.Count; } }

        public void Add(Hero hero)
        {
            data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero hero = data.FirstOrDefault(x => x.Name == name);
            data.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = data.OrderByDescending(x => x.Item.Strength).First();

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = data.OrderByDescending(x => x.Item.Ability).First();

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = data.OrderByDescending(x => x.Item.Intelligence).First();

            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Hero hero in data)
            {
                sb.AppendLine($"Hero: {hero.Name} – {hero.Level}lvl");
                sb.AppendLine("Item:");
                sb.AppendLine($"  * Strength: {hero.Item.Strength}");
                sb.AppendLine($"  * Ability: {hero.Item.Ability}");
                sb.AppendLine($"  * Intelligence: {hero.Item.Intelligence}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
