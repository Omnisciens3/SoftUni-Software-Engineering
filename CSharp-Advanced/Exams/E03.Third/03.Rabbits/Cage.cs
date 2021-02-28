using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Rabbit rabbit)
        {
            if (data.Count < Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit == null)
            {
                return false;
            }

            data.Remove(rabbit);

            return true;
        }

        public void RemoveSpecies(string species)
        {
            //Rabbit[] rabbit = data.Where(s => s.Species == species).ToArray();

            //foreach (var item in rabbit)
            //{
            //    data.Remove(item);
            //}

            data.RemoveAll(r => r.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);
            rabbit.Available = false;

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbitsToSell = data.Where(r => r.Species == species).ToArray();

            foreach (Rabbit rabbit in rabbitsToSell)
            {
                rabbit.Available = false;
            }

            return rabbitsToSell;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {Name}:");

            foreach (Rabbit rabbit in data.Where(a => a.Available == true))
            {
                sb.AppendLine($"Rabbit ({rabbit.Species}): {rabbit.Name}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
