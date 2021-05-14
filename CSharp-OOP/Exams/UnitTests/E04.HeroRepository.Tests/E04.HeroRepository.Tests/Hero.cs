using System;
using System.Collections.Generic;
using System.Text;

namespace E04.HeroRepository.Tests
{
    public class Hero
    {
        public Hero(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name { get; }

        public int Level { get; }
    }
}
