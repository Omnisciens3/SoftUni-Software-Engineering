using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Models.Entities.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private readonly List<IAnimal> procedureHistory;

        protected Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }

        public IReadOnlyCollection<IAnimal> ProcedureHistory
            => this.procedureHistory.AsReadOnly();

        public string History()
        {
            var result = new StringBuilder();

            foreach (var animal in this.procedureHistory)
            {
                result.AppendLine($"{animal}");
            }

            return result.ToString().TrimEnd();
        }

        public abstract void DoService(IAnimal animal, int procedureTime);

        protected void AddAnimalProcedure(IAnimal animal)
        {
            this.procedureHistory.Add(animal);
        }
    }
}
