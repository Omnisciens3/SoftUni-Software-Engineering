using E06.SantaWorkshop.Models.Dwarfs.Contracts;
using E06.SantaWorkshop.Models.Presents.Contracts;
using E06.SantaWorkshop.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SantaWorkshop.Models.Workshops.Models
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {

        }
        public void Craft(IPresent present, IDwarf dwarf)
        {

            foreach (var instrument in dwarf.Instruments)
            {
                while (!instrument.IsBroken())
                {
                    if (dwarf.Energy == 0)
                    {
                        break;
                    }
                    present.GetCrafted();
                    dwarf.Work();
                    instrument.Use();
                    if (present.IsDone())
                    {
                        break;
                    }
                }
                if (present.IsDone())
                {
                    break;
                }

            }

        }

    }
}
