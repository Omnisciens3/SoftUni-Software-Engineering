using E03.ViceCity.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03.ViceCity.Repositories.Contracts
{
    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }

        void Add(IGun model);

        bool Remove(IGun model);

        IGun Find(string name);

    }
}
