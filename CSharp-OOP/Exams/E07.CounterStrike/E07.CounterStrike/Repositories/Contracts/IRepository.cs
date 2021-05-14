using System;
using System.Collections.Generic;
using System.Text;

namespace E07.CounterStrike.Repositories.Contracts
{
    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }

        void Add(T model);

        bool Remove(T model);

        T FindByName(string name);
    }
}
