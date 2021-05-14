using E07.CounterStrike.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E07.CounterStrike.Repositories.Models
{
    public class GunRepository : Repository<IGun>
    {
        public GunRepository()
            : base()
        {

        }
        public override IGun FindByName(string name)
        {
            return this.Models.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
