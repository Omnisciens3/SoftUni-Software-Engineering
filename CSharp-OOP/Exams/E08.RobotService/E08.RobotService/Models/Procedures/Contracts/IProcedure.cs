using E08.RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E08.RobotService.Models.Procedures.Contracts
{
    public interface IProcedure
    {
        string History();

        void DoService(IRobot robot, int procedureTime);
    }
}
