using E03.ViceCity.Models.Neghbourhoods.Contracts;
using E03.ViceCity.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03.ViceCity.Models.Neghbourhoods.Models
{
    public class Neighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {

            foreach (var gun in mainPlayer.GunRepository.Models)
            {
                while (gun.CanFire)
                {
                    if (civilPlayers.Count == 0)
                    {
                        break;
                    }
                    int shoots = gun.Fire();
                    IPlayer player = civilPlayers.First();
                    player.TakeLifePoints(shoots);
                    if (!player.IsAlive)
                    {
                        civilPlayers.Remove(player);
                    }
                }
            }
            foreach (var player in civilPlayers)
            {
                foreach (var gun in player.GunRepository.Models)
                {
                    while (gun.CanFire)
                    {
                        int shoots = gun.Fire();
                        mainPlayer.TakeLifePoints(shoots);
                        if (!mainPlayer.IsAlive)
                        {
                            break;
                        }
                    }
                    if (!mainPlayer.IsAlive)
                    {
                        break;
                    }
                }
                if (!mainPlayer.IsAlive)
                {
                    break;
                }
            }
        }
    }
}
