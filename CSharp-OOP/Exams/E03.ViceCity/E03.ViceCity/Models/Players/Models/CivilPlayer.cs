using System;
using System.Collections.Generic;
using System.Text;

namespace E03.ViceCity.Models.Players.Models
{
    public class CivilPlayer : Player
    {
        private const int LIFE_POINTS = 50;
        public CivilPlayer(string name)
            : base(name, LIFE_POINTS)
        {
        }
    }
}
