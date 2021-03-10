using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private const int MinStatsValue = 0;
        private const int MaxStatsValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name;
            private set
            {
                Validator.ThrowIfStringIsNullOrWhitespace(value, GlobalConstants.InvalidNameErrorMessage);

                name = value;
            }
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(value, MinStatsValue, MaxStatsValue, $"{nameof(Endurance)} should be between 0 and 100.");

                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(value, MinStatsValue, MaxStatsValue, $"{nameof(Sprint)} should be between 0 and 100.");

                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(value, MinStatsValue, MaxStatsValue, $"{nameof(Dribble)} should be between 0 and 100.");

                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(value, MinStatsValue, MaxStatsValue, $"{nameof(Passing)} should be between 0 and 100.");

                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(value, MinStatsValue, MaxStatsValue, $"{nameof(Shooting)} should be between 0 and 100.");

                shooting = value;
            }
        }

        public double AverageSkillPoints
        {
            get
            {
                return Math.Round((Endurance + Sprint + Dribble + Passing + Shooting) / 5.0);
            }
        }
    }
}
