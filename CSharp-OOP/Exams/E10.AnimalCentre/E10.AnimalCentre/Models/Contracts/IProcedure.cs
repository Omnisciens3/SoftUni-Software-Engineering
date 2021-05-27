using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Models.Contracts
{
    public interface IProcedure
    {
        IReadOnlyCollection<IAnimal> ProcedureHistory { get; }

        string History();

        void DoService(IAnimal animal, int procedureTime);
    }
}
