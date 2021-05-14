using E07.CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E07.CounterStrike.Repositories.Models
{
    public class PlayerRepository : Repository<IPlayer>
    {
        public PlayerRepository()
            : base()
        {

        }
        public override IPlayer FindByName(string name)
            => this.Models.Where(x => x.Username == name).FirstOrDefault();
    }
}
