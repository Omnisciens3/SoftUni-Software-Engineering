using E10.AnimalCentre.Common;
using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Models.Entities.Procedures
{
    public class Chip : Procedure
    {
        private const int DecreasedHappines = 5;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughProcedureTime);
            }

            if (animal.IsChipped)
            {
                throw new ArgumentException(
                    string.Format(ExceptionMessages.AnimalAlreadyChipped, animal.Name));
            }

            this.AddAnimalProcedure(animal);

            animal.ProcedureTime -= procedureTime;
            animal.Happiness -= DecreasedHappines;
            animal.IsChipped = true;
        }
    }
}
