namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Present present;
        private Bag bag;
        [SetUp]
        public void Setup()
        {
            present = new Present("Chichi", 13.00);
            bag = new Bag();
        }

        [Test]
        public void TestBothCtorsNotNull()
        {
            Assert.IsNotNull(present);
            Assert.IsNotNull(bag);
        }

        [Test]
        public void BagCreateAndGetPresent()
        {
            bag.Create(present);
            var expectedResult = bag.GetPresent("Chichi");
            Assert.AreEqual(expectedResult, present);
        }
        [Test]
        public void BagRemoveMethod()
        {
            var result = bag.Remove(present);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void RemovePresentReturnsTrue()
        {
            bag.Create(present);
            Assert.AreEqual(true, bag.Remove(present));
        }

        [TestCase(null)]
        public void IfPresentIsInvalid(Present present)
        {
            if (present == null)
            {
                Assert.Throws<ArgumentNullException>(() => bag.Create(present));
            }
            present = new Present("Chichi", 13.00);

            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));

        }
        [Test]
        public void GetPresentsCollection()
        {
            List<Present> presents = new List<Present>();
            presents.Add(present);
            bag.Create(present);
            var expectedResult = presents.AsReadOnly();
            Assert.AreEqual(expectedResult, bag.GetPresents());

        }

        [Test]
        public void GetPresentWithLeastMagic()
        {
            var expectedResult = new Present("Chichi", 13.00);
            bag.Create(present);
            bag.Create(new Present("Chichi1", 17.00));
            bag.Create(new Present("Chichi2", 23.00));
            var result = bag.GetPresentWithLeastMagic();
            Assert.AreEqual(expectedResult.Name, result.Name);
        }
    }
}
