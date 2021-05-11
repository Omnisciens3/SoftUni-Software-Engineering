using E04.SpaceStation.Models.Planets;
using E04.SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E04.SpaceStation.Repositories.Models
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> models;

        public PlanetRepository()
        {
            this.models = new List<IPlanet>();
        }
        public IReadOnlyCollection<IPlanet> Models
            => this.models.AsReadOnly();

        public void Add(IPlanet model)
        {
            this.models.Add(model);
        }

        public IPlanet FindByName(string name)
            => this.models.Where(m => m.Name == name).FirstOrDefault();

        public bool Remove(IPlanet model)
            => this.models.Remove(model);
    }
}
