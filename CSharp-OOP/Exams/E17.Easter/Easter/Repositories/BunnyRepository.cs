using Easter.Models.Bunnies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories
{
    public class BunnyRepository : Repository<IBunny>
    {
        public BunnyRepository()
            :base()
        {

        }

        public override IBunny FindByName(string name) => models.Where(x => x.Name == name).FirstOrDefault();
    }
}
