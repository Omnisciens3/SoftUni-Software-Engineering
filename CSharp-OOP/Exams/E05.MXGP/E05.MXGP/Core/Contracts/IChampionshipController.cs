using System;
using System.Collections.Generic;
using System.Text;

namespace E05.MXGP.Core.Contracts
{
    public interface IChampionshipController
    {
        string CreateRider(string riderName);

        string CreateMotorcycle(string type, string model, int horsePower);

        string CreateRace(string name, int laps);

        string AddRiderToRace(string raceName, string riderName);

        string AddMotorcycleToRider(string riderName, string motorcycleModel);

        string StartRace(string raceName);
    }
}
