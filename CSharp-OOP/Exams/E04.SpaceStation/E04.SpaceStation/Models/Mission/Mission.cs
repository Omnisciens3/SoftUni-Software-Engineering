using E04.SpaceStation.Models.Astronauts.Contracts;
using E04.SpaceStation.Models.Planets;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04.SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        private IList<string> items;
        public Mission()
        {
            this.items = new List<string>();
        }
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var astronaut in astronauts)
            {
                if (!astronaut.CanBreath)
                {
                    continue;
                }
                foreach (var item in planet.Items)
                {
                    if (astronaut.CanBreath)
                    {
                        astronaut.Bag.Items.Add(item);
                        this.items.Add(item);
                        astronaut.Breath();
                    }
                }
                RemovePlanetItems(planet);
            }
        }

        private void RemovePlanetItems(IPlanet planet)
        {
            foreach (var item in this.items)
            {
                planet.Items.Remove(item);
            }
            this.items.Clear();
        }
    }
}
