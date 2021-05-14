using E07.CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E07.CounterStrike.Models.Maps.Contracts
{
    public interface IMap
    {
        string Start(ICollection<IPlayer> players);
    }
}
