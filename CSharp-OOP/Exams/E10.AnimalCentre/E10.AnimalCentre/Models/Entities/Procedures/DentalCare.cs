using E10.AnimalCentre.Common;
using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Models.Entities.Procedures
{
    public class DentalCare : Procedure
    {
        private const int AdditionalHappines = 12;
        private const int AdditionalEnergy = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughProcedureTime);
            }

            this.AddAnimalProcedure(animal);

            animal.ProcedureTime -= procedureTime;
            animal.Happiness += AdditionalHappines;
            animal.Energy += AdditionalEnergy;
        }
    }
}
