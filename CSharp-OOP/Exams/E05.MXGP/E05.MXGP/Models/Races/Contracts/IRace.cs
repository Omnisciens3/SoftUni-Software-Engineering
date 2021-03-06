﻿using E05.MXGP.Models.Riders.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.Models.Races.Contracts
{
    public interface IRace
    {
        string Name { get; }

        int Laps { get; }

        IReadOnlyCollection<IRider> Riders { get; }

        void AddRider(IRider rider);
    }
}
