﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = data.FirstOrDefault(r => r.Name == name);

            if (racer == null)
            {
                return false;
            }

            return true;
        }

        public Racer GetOldestRacer()
        {
            Racer racer = data.OrderByDescending(a => a.Age).FirstOrDefault();

            return racer;
        }

        public Racer GetRacer(string name)
        {
            Racer racer = data.FirstOrDefault(n => n.Name == name);

            return racer;
        }

        public Racer GetFastestRacer()
        {
            Racer racer = data.OrderByDescending(c => c.Car.Speed).FirstOrDefault();

            return racer;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {Name}:");

            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
