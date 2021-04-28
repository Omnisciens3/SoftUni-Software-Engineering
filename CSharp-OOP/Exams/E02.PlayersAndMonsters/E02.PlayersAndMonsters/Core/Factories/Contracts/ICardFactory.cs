using E02.PlayersAndMonsters.Models.Cards.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Core.Factories.Contracts
{
    public interface ICardFactory
    {
        ICard CreateCard(string type, string name);
    }
}
