using E02.PlayersAndMonsters.Models.Cards.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Repositories.Contracts
{
    public interface ICardRepository
    {
        int Count { get; }

        IReadOnlyCollection<ICard> Cards { get; }

        void Add(ICard card);

        bool Remove(ICard card);

        ICard Find(string name);
    }
}
