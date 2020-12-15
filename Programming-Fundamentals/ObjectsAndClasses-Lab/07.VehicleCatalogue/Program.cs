using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();

            string input = Console.ReadLine();
            int count = 0;

            while (input != "end")
            {
                string[] tokens = input.Split("/");
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if (type == "Car")
                {
                    string horsePower = tokens[3];
                    Cars currentCar = new Cars(type, brand, model, horsePower);
                    cars.Add(currentCar);
                }
                else
                {
                    string weight = tokens[3];
                    Trucks currentTruck = new Trucks(type, brand, model, weight);
                    trucks.Add(currentTruck);
                    count++;
                }

                input = Console.ReadLine();
            }

            List<Cars> sorted = cars.OrderBy(x => x.Brand).ToList();
            List<Trucks> sortedTrucks = trucks.OrderBy(x => x.Brand).ToList();

            Console.WriteLine($"Cars:");

            foreach (Cars vehicle in sorted)
            {
                Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
            }

            if (count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Trucks trucks1 in sortedTrucks)
                {
                    Console.WriteLine($"{trucks1.Brand}: {trucks1.Model} - {trucks1.Weight}kg");
                }
            }
        }
    }

    class Cars
    {
        public Cars(string type, string brand, string model, string horsePower)
        {
            Type = type;
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }

    }

    class Trucks
    {
        public Trucks(string type, string brand, string model, string weight)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

    }
}
