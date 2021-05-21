using E08.RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E08.RobotService.Models.Garages.Contracts
{
    public interface IGarage
    {
        IReadOnlyDictionary<string, IRobot> Robots { get; }

        void Manufacture(IRobot robot);

        void Sell(string robotName, string ownerName);
    }
}
