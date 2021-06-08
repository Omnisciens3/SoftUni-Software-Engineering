using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;

        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("me", "1");
        }

        [Test]
        public void WhenCellDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("go nqma", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void WhenCellIsAlreadyTaken_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("A2", new Item("pesho", "3"));
            });

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }

        [Test]
        public void WhenItemAlreadyExists_ShouldThrowException()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("B3", item);
            });

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }

        [Test]
        public void WhenItemIsAdded_ShouldReturnCorrectMessage()
        {
            string result = vault.AddItem("A2", item);

            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }

        [Test]
        public void WhenItemIsAdded_ShouldSetItemToCell()
        {
            vault.AddItem("A2", item);

            Assert.AreEqual(item, vault.VaultCells["A2"]);
        }

        [Test]
        public void WhenRemoveCellAndCellDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("go nqma", item);
            });

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void WhenRemoveCellAndItemDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A2", item);
            });

            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");
        }

        [Test]
        public void WhenItemIsRemoved_ShouldReturnCorrectMessage()
        {
            vault.AddItem("A2", item);

            string result = vault.RemoveItem("A2", item);

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }

        [Test]
        public void WhenItemIsRemoved_ShouldMakeTheCellNull()
        {
            vault.AddItem("A2", item);

            vault.RemoveItem("A2", item);

            Assert.AreEqual(null, vault.VaultCells["A2"]);
        }


        //For testing the constructor.
        [Test]
        public void WhenVaultIsInitialised_ShouldHaveCorrectCells()
        {
            var initialValue = new Dictionary<string, Item>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            var initialValueAsList = initialValue.ToImmutableDictionary().ToList();

            var vaultValuesAsList = vault.VaultCells.ToList();

            for (int i = 0; i < initialValueAsList.Count; i++)
            {
                Assert.AreEqual(initialValueAsList[i].Key, vaultValuesAsList[i].Key);
                Assert.AreEqual(initialValueAsList[i].Value, vaultValuesAsList[i].Value);
            }
        }
    }
}