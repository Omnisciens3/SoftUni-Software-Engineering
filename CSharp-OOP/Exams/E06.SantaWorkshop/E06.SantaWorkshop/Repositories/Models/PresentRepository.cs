using E06.SantaWorkshop.Models.Presents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E06.SantaWorkshop.Repositories.Models
{
    public class PresentRepository : Repository<IPresent>
    {
        public PresentRepository()
            : base()
        {
        }

        public override IPresent FindByName(string name)
        => this.models.Where(x => x.Name == name).FirstOrDefault();
    }
}
