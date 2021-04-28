using E02.PlayersAndMonsters.Core.Factories.Contracts;
using E02.PlayersAndMonsters.Models.Players.Contracts;
using E02.PlayersAndMonsters.Models.Players.Models;
using E02.PlayersAndMonsters.Repositories;
using E02.PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Core.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = null;
            ICardRepository cardRepository = new CardRepository();
            if (type == "Beginner")
            {
                player = new Beginner(cardRepository, username);
            }
            else if (type == "Advanced")
            {
                player = new Advanced(cardRepository, username);
            }
            return player;
        }
    }
}
