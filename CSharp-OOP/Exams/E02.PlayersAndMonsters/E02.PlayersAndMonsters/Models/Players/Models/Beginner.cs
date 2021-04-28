﻿using E02.PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Models.Players.Models
{
    public class Beginner : Player
    {
        public Beginner(ICardRepository cardRepository, string username)
            : base(cardRepository, username, 50)
        {

        }

    }
}
