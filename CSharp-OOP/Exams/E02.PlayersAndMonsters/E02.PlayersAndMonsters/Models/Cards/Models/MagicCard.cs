using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Models.Cards.Models
{
    public class MagicCard : Card
    {
        public MagicCard(string name)
            : base(name, 5, 80)
        {
        }
    }
}
