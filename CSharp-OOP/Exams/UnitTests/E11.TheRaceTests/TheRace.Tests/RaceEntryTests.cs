using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
        }

        [Test]
        public void Counter_IsZeroByDefault()
        {
            Assert.That(raceEntry.Counter, Is.Zero);
        }

        [Test]
        public void Counter_Increases_WhenAddingDriver()
        {
            raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla", 400, 5000)));

            Assert.That(raceEntry.Counter, Is.EqualTo(1));
        }

        [Test]
        public void AddDriver_ThrowsException_WhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(null));
        }

        [Test]
        public void AddDriver_ThrowsException_WhenDriverNameExists()
        {
            var driverName = "Nasko";

            raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Tesla", 400, 5000)));

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Tesla GIgaTruck", 300, 8000))));
        }

        [Test]
        public void AddDriver_ReturnsExpectedMessage()
        {
            var driverName = "Masko";
            var actual = raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Tesla", 400, 5000)));

            var expected = $"Driver {driverName} added in race.";

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void CalculateAverageHorsePower_ThrowsException_WhenLessParticipants()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());

            raceEntry.AddDriver(new UnitDriver("Masko", new UnitCar("Tesla", 500, 8000)));

            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePower_ReturnsExpectedCalculations()
        {
            double expected = 0;
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                int hp = 450 + i;
                expected += hp;

                raceEntry.AddDriver(new UnitDriver($"Name-{i}", new UnitCar("Tesla", hp, 8000)));
            }

            expected /= n;

            double actual = raceEntry.CalculateAverageHorsePower();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}