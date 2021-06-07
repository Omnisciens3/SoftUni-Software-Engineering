using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private const int NameMinLength = 5;
        private const int MinLaps = 1;

        private string name;
        private int laps;

        private readonly IDictionary<string, IDriver> driversByName;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;

            driversByName = new Dictionary<string, IDriver>();
        }

        public string Name
        {
            get => name;
            private set
            {
                Validator.ThrowIfStringIsNullEmptyOrLessThan(value, NameMinLength, string.Format(ExceptionMessages.InvalidName, value, NameMinLength));

                name = value;
            }
        }

        public int Laps 
        {
            get => laps;
            private set
            {
                if (value < MinLaps)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, MinLaps));
                }

                laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers => driversByName.Values.ToList(); //правим драйвърите в лист, за да можем да ги върнем като IReadOnlyCollection;

        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(ExceptionMessages.DriverInvalid);
            }

            if (!driver.CanParticipate)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }

            if (driversByName.ContainsKey(driver.Name))
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, Name));
            }

            driversByName.Add(driver.Name, driver);
        }
    }
}
