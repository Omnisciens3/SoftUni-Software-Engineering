using E04.SpaceStation.Models.Astronauts.Contracts;
using E04.SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E04.SpaceStation.Repositories.Models
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private List<IAstronaut> models;

        public AstronautRepository()
        {
            this.models = new List<IAstronaut>();
        }
        public IReadOnlyCollection<IAstronaut> Models
            => this.models.AsReadOnly();

        public void Add(IAstronaut model)
        {
            this.models.Add(model);
        }

        public IAstronaut FindByName(string name)
            => this.models.Where(m => m.Name == name).FirstOrDefault();

        public bool Remove(IAstronaut model)
            => this.models.Remove(model);
    }
}
