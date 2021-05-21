using E08.RobotService.Models.Garages.Contracts;
using E08.RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E08.RobotService.Models.Garages.Models
{
    public class Garage : IGarage
    {
        private Dictionary<string, IRobot> robots;

        public Garage()
        {
            this.robots = new Dictionary<string, IRobot>();
        }

        public IReadOnlyDictionary<string, IRobot> Robots
            => this.robots;
        public int Capacity => 10;
        public void Manufacture(IRobot robot)
        {

            if (this.robots.Count == this.Capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            else if (this.robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException($"Robot {robot.Name} already exist");
            }
            else
            {
                this.robots.Add(robot.Name, robot);
            }
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!this.robots.ContainsKey(robotName))
            {
                throw new ArgumentException("Robot {robot name} does not exist");
            }
            IRobot robot = this.robots.Where(x => x.Key == robotName).Select(x => x.Value).FirstOrDefault();
            robot.IsBought = true;
            robot.Owner = ownerName;
            this.robots.Remove(robot.Name);
        }

    }
}
