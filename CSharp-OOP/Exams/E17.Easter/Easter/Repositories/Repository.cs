using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Repositories
{
    public abstract class Repository<T> : IRepository<T>
    {
        protected List<T> models;

        protected Repository()
        {
            models = new List<T>();
        }

        public IReadOnlyCollection<T> Models => models.AsReadOnly();

        public void Add(T model)
        {
            models.Add(model);
        }

        public abstract T FindByName(string name);

        public bool Remove(T model) => models.Remove(model);
    }
}
