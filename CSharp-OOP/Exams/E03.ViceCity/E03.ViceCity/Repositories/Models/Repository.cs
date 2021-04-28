using E03.ViceCity.Models.Guns.Contracts;
using E03.ViceCity.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03.ViceCity.Repositories.Models
{
    public class Repository : IRepository<IGun>
    {
        private List<IGun> models;
        public Repository()
        {
            this.models = new List<IGun>();
        }
        public IReadOnlyCollection<IGun> Models => this.models.AsReadOnly();
        public void Add(IGun model)
        {
            if (!this.models.Any(m => m.Name == model.Name))
            {
                this.models.Add(model);
            }
        }

        public IGun Find(string name)
                => this.models.FirstOrDefault(m => m.Name == name);

        public bool Remove(IGun model)
                => this.models.Remove(model);
    }
}
