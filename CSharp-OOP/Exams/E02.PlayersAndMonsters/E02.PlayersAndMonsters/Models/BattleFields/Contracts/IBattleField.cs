using E02.PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Models.BattleFields.Contracts
{
    public interface IBattleField
    {
        void Fight(IPlayer attackPlayer, IPlayer enemyPlayer);
    }
}
