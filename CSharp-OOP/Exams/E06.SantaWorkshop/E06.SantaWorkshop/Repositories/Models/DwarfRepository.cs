using E06.SantaWorkshop.Models.Dwarfs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E06.SantaWorkshop.Repositories.Models
{
    public class DwarfRepository : Repository<IDwarf>
    {
        public DwarfRepository()
            : base()
        {

        }

        public override IDwarf FindByName(string name)
        => this.models.Where(x => x.Name == name).FirstOrDefault();
    }
}
