using E03.ViceCity.Models.Guns.Contracts;
using E03.ViceCity.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03.ViceCity.Models.Players.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        bool IsAlive { get; }

        IRepository<IGun> GunRepository { get; }

        int LifePoints { get; }

        void TakeLifePoints(int points);
    }
}
