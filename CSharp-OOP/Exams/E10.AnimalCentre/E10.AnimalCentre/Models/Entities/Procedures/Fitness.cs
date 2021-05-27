using E10.AnimalCentre.Common;
using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Models.Entities.Procedures
{
    public class Fitness : Procedure
    {
        private const int DecreasedHappines = 3;
        private const int AdditionalEnergy = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughProcedureTime);
            }

            this.AddAnimalProcedure(animal);

            animal.ProcedureTime -= procedureTime;
            animal.Happiness -= DecreasedHappines;
            animal.Energy += AdditionalEnergy;
        }
    }
}
