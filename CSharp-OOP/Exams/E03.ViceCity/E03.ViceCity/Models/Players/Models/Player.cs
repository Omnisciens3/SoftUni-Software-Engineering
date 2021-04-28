using E03.ViceCity.Models.Guns.Contracts;
using E03.ViceCity.Models.Players.Contracts;
using E03.ViceCity.Repositories.Contracts;
using E03.ViceCity.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03.ViceCity.Models.Players.Models
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        private IRepository<IGun> repository;
        private Player()
        {
            this.repository = new Repository();
        }
        protected Player(string name, int lifePoints)
            : this()
        {
            this.Name = name;
            this.LifePoints = lifePoints;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }
                this.name = value;
            }
        }

        public bool IsAlive => this.LifePoints > 0;

        public IRepository<IGun> GunRepository
            => this.repository;

        public int LifePoints
        {
            get
            {
                return this.lifePoints;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }
                this.lifePoints = value;
            }
        }

        public void TakeLifePoints(int points)
        {
            if (this.LifePoints < points)
            {
                this.LifePoints = 0;
            }
            else
            {
                this.LifePoints -= points;
            }
        }
    }
}
