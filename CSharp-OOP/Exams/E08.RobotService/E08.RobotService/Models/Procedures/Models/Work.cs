using E08.RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E08.RobotService.Models.Procedures.Models
{
    public class Work : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {

            base.DoService(robot, procedureTime);
            robot.Energy -= 6;
            robot.Happiness += 12;
        }
    }
}
