using E05.MXGP.Models.Riders.Contracts;
using E05.MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E05.MXGP.Repositories.Models
{
    public class RiderRepository : IRepository<IRider>
    {
        private List<IRider> data;
        public RiderRepository()
        {
            this.data = new List<IRider>();
        }
        public void Add(IRider model)
        => this.data.Add(model);

        public IReadOnlyCollection<IRider> GetAll()
        => this.data.AsReadOnly();

        public IRider GetByName(string name)
        => this.data.Where(x => x.Name == name).FirstOrDefault();

        public bool Remove(IRider model)
           => this.data.Remove(model);
    }
}
