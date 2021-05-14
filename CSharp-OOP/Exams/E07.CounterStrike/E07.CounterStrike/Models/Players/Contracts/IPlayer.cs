﻿using E07.CounterStrike.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E07.CounterStrike.Models.Players.Contracts
{
    public interface IPlayer
    {
        string Username { get; }

        int Health { get; }

        int Armor { get; }

        IGun Gun { get; }

        bool IsAlive { get; }

        void TakeDamage(int points);
    }
}
