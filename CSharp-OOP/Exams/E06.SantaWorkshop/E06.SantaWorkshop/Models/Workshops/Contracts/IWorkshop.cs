using E06.SantaWorkshop.Models.Dwarfs.Contracts;
using E06.SantaWorkshop.Models.Presents.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.Models.Workshops.Contracts
{
    public interface IWorkshop
    {
        void Craft(IPresent present, IDwarf dwarf);
    }
}
