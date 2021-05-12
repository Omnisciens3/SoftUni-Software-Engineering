using E05.MXGP.Models.Motorcycles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.Models.Riders.Contracts
{
    public interface IRider
    {
        string Name { get; }

        IMotorcycle Motorcycle { get; }

        int NumberOfWins { get; }

        bool CanParticipate { get; }

        void WinRace();

        void AddMotorcycle(IMotorcycle motorcycle);
    }
}
