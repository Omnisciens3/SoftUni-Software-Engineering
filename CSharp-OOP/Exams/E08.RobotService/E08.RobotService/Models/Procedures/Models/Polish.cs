using E08.RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E08.RobotService.Models.Procedures.Models
{
    public class Polish : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {

            base.DoService(robot, procedureTime);
            robot.Happiness -= 7;
        }
    }
}
