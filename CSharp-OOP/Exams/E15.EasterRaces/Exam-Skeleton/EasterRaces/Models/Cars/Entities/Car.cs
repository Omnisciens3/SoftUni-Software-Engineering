using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private const int ModelMinLenght = 4;

        private string model;
        private int horsePower;
        private double cubicCentimeters;
        private int minHorsePower;
        private int maxHorsePower;

        protected Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            //Важно е да зададем стойностите на мин и макс конски сили преди да сетнем стойността на HorsePower, защото тя всъщност се валидира спрямо тези две стойности => ако тези две стойности са поставени под HorsePower, валидацията в пропъртито HorsePower ще се извърши спрямо дифолтните стойности на int, демек 0... По този начин валидацията ни става невалидна!
            this.minHorsePower = minHorsePower;
            this.maxHorsePower = maxHorsePower;

            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;
        }

        public string Model 
        {
            get => model;
            private set
            {
                //много е важно като правим такъв тип проверка, първо да проверим дали стринга е null, защото в противен случай, ако value = null и ние вземем value.Lenght < 4 ==> това веднага ще ни хвърли NullReferenceException. Затова е МНОГО важно тази проверка да бъде така структурирана.

                //if (string.IsNullOrWhiteSpace(value) || value.Length < ModelMinLenght)
                //{
                //    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel, value, ModelMinLenght));
                //}

                Validator.ThrowIfStringIsNullEmptyOrLessThan(value, ModelMinLenght, string.Format(ExceptionMessages.InvalidModel, value, ModelMinLenght));

                model = value;
            }
        }

        public int HorsePower 
        {
            get => horsePower;
            private set
            {
                if (value < minHorsePower || value > maxHorsePower)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                horsePower = value;
            } 
        }

        public double CubicCentimeters { get; private set; }

        public double CalculateRacePoints(int laps)
        {
            //cubic centimeters / horsepower * laps

            return CubicCentimeters / HorsePower * laps;
        }
    }
}
