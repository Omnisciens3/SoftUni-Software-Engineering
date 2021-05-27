using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Factories.Contracts
{
    public interface IProcedureFactory
    {
        IProcedure CreateProcedure(string type);
    }
}
