using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalog
{
    class Program
    {
        static List<string> Fragmented = new List<string>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Fragmented = input.Split('/').ToList();
            string command = Fragmented[0];
            Catalog collection = new Catalog();
            while (command != "end")
            {
                if (command == "Car")
                {
                    Car newCar = new Car
                    {
                        Brand = Fragmented[1],
                        Model = Fragmented[2],
                        HorsePower = double.Parse(Fragmented[3])
                    };
                    collection.CarsCatalog.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck
                    {
                        Brand = Fragmented[1],
                        Model = Fragmented[2],
                        Weight = double.Parse(Fragmented[3])
                    };
                    collection.TrucksCatalog.Add(newTruck);
                }

                Fragmented = Console.ReadLine().Split('/').ToList();
                command = Fragmented[0];
            }

            Console.Write(collection.ToString());
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return new string($"{Brand}: {Model} - {Weight}kg");
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            return new string($"{Brand}: {Model} - {HorsePower}hp");
        }
    }

    public class Catalog
    {
        public List<Truck> TrucksCatalog { get; set; }
        public List<Car> CarsCatalog { get; set; }

        public Catalog()
        {
            TrucksCatalog = new List<Truck>();
            CarsCatalog = new List<Car>();
        }

        public override string ToString()
        {
            List<Car> orderedCars = CarsCatalog.OrderBy(c => c.Brand).ToList();
            List<Truck> orderedTrucks = TrucksCatalog.OrderBy(t => t.Brand).ToList();
            StringBuilder sb = new StringBuilder();
            if (orderedCars.Count > 0)
            {
                sb.AppendLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    sb.AppendLine(car.ToString());
                }
            }
            if (orderedTrucks.Count > 0)
            {
                sb.AppendLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    sb.AppendLine(truck.ToString());
                }
            }

            return sb.ToString();
        }
    }
}