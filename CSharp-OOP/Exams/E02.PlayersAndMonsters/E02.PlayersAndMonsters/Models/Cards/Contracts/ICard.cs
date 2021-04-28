using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Models.Cards.Contracts
{
    public interface ICard
    {
        string Name { get; }

        int DamagePoints { get; set; }

        int HealthPoints { get; }
    }
}
