using Easter.Models.Eggs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories
{
    public class EggRepository : Repository<IEgg>
    {
        public EggRepository()
            : base()
        {

        }

        public override IEgg FindByName(string name) => models.Where(x => x.Name == name).FirstOrDefault();
    }
}
