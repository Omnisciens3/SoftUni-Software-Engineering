﻿using E07.CounterStrike.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E07.CounterStrike.Models.Players.Models
{
    public class Terrorist : Player
    {
        public Terrorist(string username, int health, int armor, IGun gun)
            : base(username, health, armor, gun)
        {
        }
    }
}
