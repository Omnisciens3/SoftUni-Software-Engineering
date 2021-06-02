using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> characters;
        private List<Item> items;

        public WarController()
        {
            characters = new List<Character>();
            items = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            string characterType = args[0];
            string name = args[1];

            if (characterType == nameof(Warrior))
            {
                Character warrior = new Warrior(name);

                characters.Add(warrior);
            }
            else if (characterType == nameof(Priest))
            {
                Character priest = new Priest(name);

                characters.Add(priest);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType), characterType);
            }

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];

            if (itemName == nameof(FirePotion))
            {
                Item item = new FirePotion();

                items.Add(item);
            }
            else if (itemName == nameof(HealthPotion))
            {
                Item item = new HealthPotion();

                items.Add(item);
            }
            else
            {
                throw new ArgumentException($"Invalid item {itemName}!");
            }

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character character = characters.FirstOrDefault(c => c.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            if (!items.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

            Item itemName = items.Last();

            character.Bag.AddItem(itemName);
            items.Remove(itemName);

            return $"{characterName} picked up {itemName.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            Character character = characters.FirstOrDefault(c => c.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), characterName);
            }

            Item item = character.Bag.GetItem(itemName);

            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in characters.OrderByDescending(c => c.IsAlive).ThenByDescending(h => h.Health))
            {
                sb.AppendLine(character.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string recieverName = args[1];

            Character attacking = characters.FirstOrDefault(n => n.Name == attackerName);
            Character recieving = characters.FirstOrDefault(n => n.Name == recieverName);

            if (attacking == null)
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }
            if (recieving == null)
            {
                throw new ArgumentException($"Character {recieverName} not found!");
            }
            if (attacking.GetType().Name == nameof(Priest))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail), attackerName);
            }
            if (!attacking.IsAlive)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail), attackerName);
            }
            if (attackerName == recieverName)
            {
                throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
            }

            recieving.TakeDamage(attacking.AbilityPoints);


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{attackerName} attacks {recieverName} for {attacking.AbilityPoints} hit points! {recieverName} has {recieving.Health}/{recieving.BaseHealth} HP and {recieving.Armor}/{recieving.BaseArmor} AP left!");

            if (!recieving.IsAlive)
            {
                sb.AppendLine($"{recieving.Name} is dead!");
            }

            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string receiverName = args[1];

            Priest healing = (Priest)characters.FirstOrDefault(n => n.Name == healerName);
            Character receiving = characters.FirstOrDefault(n => n.Name == receiverName);

            if (healing == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), healerName);
            }
            if (receiving == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), receiverName);
            }
            if (healing.GetType().Name == nameof(Warrior))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail), healerName);
            }

            healing.Heal(receiving);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{healing.Name} heals {receiving.Name} for {healing.AbilityPoints}! {receiving.Name} has {receiving.Health} health now!");

            return sb.ToString().TrimEnd();
        }
    }
}
