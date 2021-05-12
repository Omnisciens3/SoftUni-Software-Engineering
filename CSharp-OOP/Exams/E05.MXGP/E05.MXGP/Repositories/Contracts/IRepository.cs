using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.Repositories.Contracts
{
    public interface IRepository<T>
    {
        T GetByName(string name);

        IReadOnlyCollection<T> GetAll();

        void Add(T model);

        bool Remove(T model);
    }
}
