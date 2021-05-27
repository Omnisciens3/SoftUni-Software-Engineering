using E10.AnimalCentre.Factories.Contracts;
using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace E10.AnimalCentre.Factories
{
    public class ProcedureFactory : IProcedureFactory
    {
        public IProcedure CreateProcedure(string type)
        {
            var procedureType = Assembly
                 .GetExecutingAssembly()
                 .GetTypes()
                 .Where(x => x.Name == type)
                 .FirstOrDefault();

            var procedureInstance = (IProcedure)Activator.CreateInstance(procedureType);

            return procedureInstance;
        }
    }
}
