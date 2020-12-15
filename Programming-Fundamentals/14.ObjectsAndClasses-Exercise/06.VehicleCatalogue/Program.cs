using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                string type = cmdArgs[0].ToLower();
                string model = cmdArgs[1];
                string colour = cmdArgs[2].ToLower();
                int horsePower = int.Parse(cmdArgs[3]);

                Vehicle currentVehicle = new Vehicle(type, model, colour, horsePower);

                catalogue.Add(currentVehicle);

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "Close the Catalogue")
            {
                string modelType = secondCommand;

                Vehicle printCar = catalogue.First(x=>x.Model == modelType);

                Console.WriteLine(printCar);

                secondCommand = Console.ReadLine();
            }

            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHP = onlyCars.Sum(x => x.HorsePower);
            double totalTrucksHP = onlyTrucks.Sum(x => x.HorsePower);

            double averageCarHP = 0;
            double averageTruckHP = 0;

            if (onlyCars.Count > 0)
            {
                averageCarHP = totalCarsHP / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                averageTruckHP = totalTrucksHP / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string colour, int horsePower)
        {
            Type = type;
            Model = model;
            Colour = colour;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Colour}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }

    }
}
