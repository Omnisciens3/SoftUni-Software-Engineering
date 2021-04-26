using System;
using System.Collections.Generic;
using System.Text;

namespace E01.MortalEngines.Entities.Contracts
{
    public interface IMachine
    {
        string Name { get; }

        IPilot Pilot { get; set; }

        double HealthPoints { get; set; }

        double AttackPoints { get; }

        double DefensePoints { get; }

        IList<string> Targets { get; }

        void Attack(IMachine target);

        string ToString();
    }
}
