using E08.RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E08.RobotService.Models.Procedures.Models
{
    public class Chip : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);
            if (robot.IsChipped)
            {
                throw new ArgumentException($"{robot.Name} is already chipped");
            }
            robot.Happiness -= 5;
            robot.IsChipped = true;
        }
    }
}
