using Easter.Core.Contracts;
using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops;
using Easter.Repositories;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Core
{
    public class Controller : IController
    {
        private BunnyRepository bunnies;
        private EggRepository eggs;
        private Workshop workshop;

        public Controller()
        {
            bunnies = new BunnyRepository();
            eggs = new EggRepository();
            workshop = new Workshop();
        }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            IBunny bunny = null;

            if (bunnyType != "HappyBunny" && bunnyType != "SleepyBunny")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidBunnyType);
            }
            else if (bunnyType == "HappyBunny")
            {
                bunny = new HappyBunny(bunnyName);
            }
            else if (bunnyType == "SleepyBunny")
            {
                bunny = new SleepyBunny(bunnyName);
            }

            bunnies.Add(bunny);

            return $"Successfully added {bunny.GetType().Name} named {bunny.Name}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IBunny bunny = bunnies.FindByName(bunnyName);

            if (bunny == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentBunny);
            }

            IDye dye = new Dye(power);
            bunny.AddDye(dye);

            return $"Successfully added dye with power {dye.Power} to bunny {bunny.Name}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            IEgg egg = new Egg(eggName, energyRequired);

            eggs.Add(egg);

            return $"Successfully added egg: {egg.Name}!";
        }

        public string ColorEgg(string eggName)
        {
            IEgg egg = eggs.FindByName(eggName);

            List<IBunny> bunniesReadyToColor = bunnies.Models
                                                      .Where(e => e.Energy >= 50)
                                                      .OrderByDescending(e => e.Energy)
                                                      .ToList();

            if (bunniesReadyToColor.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.BunniesNotReady);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var bunny in bunniesReadyToColor)
            {
                workshop.Color(egg, bunny);

                if (egg.IsDone())
                {
                    break;
                }
            }

            sb.Append($"Egg {egg.Name} is ");

            if (egg.IsDone())
            {
                sb.Append("done.");
            }
            else
            {
                sb.Append("not done.");
            }

            //RemoveBunnies(bunniesReadyToColor);

            foreach (var bunny in bunniesReadyToColor)
            {
                if (bunny.Energy == 0)
                {
                    bunnies.Remove(bunny);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{eggs.Models.Where(e => e.IsDone()).Count()} eggs are done!");
            sb.AppendLine("Bunnies info:");

            foreach (var bunny in bunnies.Models)
            {
                sb.AppendLine(bunny.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        //private void RemoveBunnies(List<IBunny> bunnies)
        //{
        //    foreach (var bunny in bunnies)
        //    {
        //        if (bunny.Energy == 0)
        //        {
        //            bunnies.Remove(bunny);
        //        }
        //    }
        //}
    }
}
