using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");
                string brand = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                Car car = new Car() { Name = brand, Mileage = mileage, Fuel = fuel };
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split(" : ");
                string cmnd = command[0];
                string carName = command[1];

                Car car = cars.FirstOrDefault(car => car.Name == carName);

                if (cmnd == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (car.Fuel - fuel < 0)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        car.Fuel -= fuel;
                        car.Mileage += distance;

                        Console.WriteLine($"{car.Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (car.Mileage >= 100000)
                    {
                        cars.Remove(car);
                        Console.WriteLine($"Time to sell the {car.Name}!");
                    }
                }
                else if (cmnd == "Refuel")
                {
                    int fuel = int.Parse(command[2]);

                    if (car.Fuel + fuel > 75)
                    {
                        fuel = 75 - car.Fuel;
                    }
                    car.Fuel += fuel;
                    Console.WriteLine($"{car.Name} refueled with {fuel} liters");

                }
                else if (cmnd == "Revert")
                {
                    int kilometers = int.Parse(command[2]);

                    car.Mileage -= kilometers;

                    if (car.Mileage < 10000)
                    {
                        car.Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car.Name} mileage decreased by {kilometers} kilometers");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars.OrderByDescending(m => m.Mileage).ThenBy(n => n.Name))
            {
                Console.Write(car);
            }
        }
    }

    class Car
    {
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.");

            return sb.ToString();
        }
    }
}