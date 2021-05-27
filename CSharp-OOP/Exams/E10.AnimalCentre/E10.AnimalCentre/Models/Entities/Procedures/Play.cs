using E10.AnimalCentre.Common;
using E10.AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E10.AnimalCentre.Models.Entities.Procedures
{
    public class Play : Procedure
    {
        private const int DecreasedEnergy = 6;
        private const int AdditionalHappiness = 12;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughProcedureTime);
            }

            this.AddAnimalProcedure(animal);

            animal.ProcedureTime -= procedureTime;
            animal.Energy -= DecreasedEnergy;
            animal.Happiness += AdditionalHappiness;
        }
    }
}
