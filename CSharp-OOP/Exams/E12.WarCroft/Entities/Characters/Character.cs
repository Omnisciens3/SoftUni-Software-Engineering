using System;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            BaseHealth = health;
            Health = health;
            BaseArmor = armor;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }

                name = value;
            }
        }

        public double BaseHealth { get; private set; }

        public double Health 
        {
            get => health;
            set
            {
                if (value >= 0 || value <= BaseHealth)
                {
                    health = value;
                }
            }
        }

        public double BaseArmor { get; private set; }

        public double Armor 
        {
            get => armor;
            private set
            {
                if (value >= 0)
                {
                    armor = value;
                }
            }
        }

        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            EnsureAlive();

            if (Armor - hitPoints > 0)
            {
                Armor -= hitPoints;
            }
            else if (Armor - hitPoints < 0)
            {
                Health -= hitPoints - Armor;

                if (Health <= 0)
                {
                    Health = 0;
                    IsAlive = false;
                }

                Armor = 0;
            }

            if (Health <= 0)
            {
                IsAlive = false;
            }
        }

        public void UseItem(Item item)
        {
            EnsureAlive();

            item.AffectCharacter(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Name} - HP: {Health}/{BaseHealth}, AP: {Armor}/{BaseArmor}, ");

            if (IsAlive)
            {
                sb.Append("Status: Alive");
            }
            else
            {
                sb.Append("Status: Dead");
            }

            return sb.ToString().TrimEnd();
        }
    }
}