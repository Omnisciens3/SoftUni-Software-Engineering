using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Models.Cards.Models
{
    public class TrapCard : Card
    {
        public TrapCard(string name)
            : base(name, 120, 5)
        {
        }
    }
}
