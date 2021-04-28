using E02.PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Core.Factories.Contracts
{
    public interface IPlayerFactory
    {
        IPlayer CreatePlayer(string type, string username);
    }
}
