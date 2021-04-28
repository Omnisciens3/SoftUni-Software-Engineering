using E02.PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Models.Players.Models
{
    public class Advanced : Player
    {
        public Advanced(ICardRepository cardRepository, string username)
            : base(cardRepository, username, 250)
        {
        }
    }
}
