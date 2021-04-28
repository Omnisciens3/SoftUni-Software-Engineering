using E02.PlayersAndMonsters.Core.Contracts;
using E02.PlayersAndMonsters.Core.Factories;
using E02.PlayersAndMonsters.Core.Factories.Contracts;
using E02.PlayersAndMonsters.Models.BattleFields.Contracts;
using E02.PlayersAndMonsters.Models.BattleFields.Models;
using E02.PlayersAndMonsters.Models.Cards.Contracts;
using E02.PlayersAndMonsters.Models.Players.Contracts;
using E02.PlayersAndMonsters.Repositories;
using E02.PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E02.PlayersAndMonsters.Core
{
    public class ManagerController : IManagerController
    {
        private ICardRepository cardRepository;
        private IPlayerRepository playerRepository;
        private IPlayerFactory playerFactory;
        private ICardFactory cardFactory;
        private IBattleField battleField;

        public ManagerController()
        {
            this.cardRepository = new CardRepository();
            this.playerRepository = new PlayerRepository();
            this.playerFactory = new PlayerFactory();
            this.cardFactory = new CardFactory();
            this.battleField = new BattleField();
        }

        public string AddPlayer(string type, string username)
        {
            IPlayer player = this.playerFactory.CreatePlayer(type, username);
            this.playerRepository.Add(player);
            return $"Successfully added player of type {type} with username: {username}";
        }

        public string AddCard(string type, string name)
        {
            ICard card = this.cardFactory.CreateCard(type, name);
            this.cardRepository.Add(card);
            return $"Successfully added card of type {type}Card with name: {name}";
        }

        public string AddPlayerCard(string username, string cardName)
        {
            IPlayer player = this.playerRepository.Find(username);
            ICard card = this.cardRepository.Find(cardName);
            player.CardRepository.Add(card);
            return $"Successfully added card: {cardName} to user: {username}";
        }

        public string Fight(string attackUser, string enemyUser)
        {
            IPlayer attack = this.playerRepository.Find(attackUser);
            IPlayer enemy = this.playerRepository.Find(enemyUser);
            this.battleField.Fight(attack, enemy);
            return $"Attack user health {attack.Health} - Enemy user health {enemy.Health}";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in this.playerRepository.Players)
            {
                sb.AppendLine(player.ToString());
                foreach (var card in player.CardRepository.Cards)
                {
                    sb.AppendLine(card.ToString());
                }
                sb.AppendLine($"###");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
