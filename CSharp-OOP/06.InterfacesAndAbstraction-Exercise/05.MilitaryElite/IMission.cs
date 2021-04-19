using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MilitaryElite
{
    public interface IMission
    {
        string CodeName { get; }

        MissionState MissionState { get; }

        void CompleteMission();
    }
}
