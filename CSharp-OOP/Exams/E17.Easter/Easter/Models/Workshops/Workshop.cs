using Easter.Models.Bunnies.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {

        }

        public void Color(IEgg egg, IBunny bunny)
        {
            foreach (var dye in bunny.Dyes)
            {
                while (!dye.IsFinished())
                {
                    if (bunny.Energy == 0)
                    {
                        break;
                    }

                    egg.GetColored();
                    bunny.Work();
                    dye.Use();

                    if (egg.IsDone())
                    {
                        break;
                    }
                }

                if (egg.IsDone())
                {
                    break;
                }

            }
        }
    }
}
