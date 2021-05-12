using E05.MXGP.Models.Motorcycles.Contracts;
using E05.MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E05.MXGP.Repositories.Models
{
    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private List<IMotorcycle> data;
        public MotorcycleRepository()
        {
            this.data = new List<IMotorcycle>();
        }

        public IReadOnlyCollection<IMotorcycle> Data
            => this.data.AsReadOnly();

        public void Add(IMotorcycle model)
        => this.data.Add(model);


        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return this.Data;
        }

        public IMotorcycle GetByName(string name)
        => this.data.Where(x => x.Model == name).FirstOrDefault();

        public bool Remove(IMotorcycle model)
            => this.data.Remove(model);
    }
}
