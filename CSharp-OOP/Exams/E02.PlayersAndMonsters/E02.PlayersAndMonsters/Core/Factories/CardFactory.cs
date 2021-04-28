using E02.PlayersAndMonsters.Core.Factories.Contracts;
using E02.PlayersAndMonsters.Models.Cards.Contracts;
using E02.PlayersAndMonsters.Models.Cards.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Core.Factories
{
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            ICard card = null;

            if (type == "Magic")
            {
                card = new MagicCard(name);
            }
            else if (type == "Trap")
            {
                card = new TrapCard(name);
            }

            return card;
        }
    }
}
