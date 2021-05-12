using E05.MXGP.Models.Races.Contracts;
using E05.MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E05.MXGP.Repositories.Models
{
    public class RaceRepository : IRepository<IRace>
    {
        private List<IRace> data;
        public RaceRepository()
        {
            this.data = new List<IRace>();
        }
        public void Add(IRace model)
        => this.data.Add(model);

        public IReadOnlyCollection<IRace> GetAll()
        => this.data.AsReadOnly();

        public IRace GetByName(string name)
            => this.data.Where(x => x.Name == name).FirstOrDefault();

        public bool Remove(IRace model)
        => this.data.Remove(model);
    }
}
