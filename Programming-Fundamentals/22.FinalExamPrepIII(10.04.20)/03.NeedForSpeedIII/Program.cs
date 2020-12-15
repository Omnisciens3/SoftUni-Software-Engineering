using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cars = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentCar = Console.ReadLine().Split("|");
                string carModel = currentCar[0];
                int mileage = int.Parse(currentCar[1]);
                int fuel = int.Parse(currentCar[2]);

                cars.Add(carModel, new Dictionary<string, int>()
                {
                    { "mileage", mileage },
                    { "fuel", fuel }
                });
                
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                string car = tokens[1];

                switch (cmd)
                {
                    case "Drive":

                        int distance = int.Parse(tokens[2]);
                        int fuel = int.Parse(tokens[3]);

                        if (cars[car]["fuel"] >= fuel)
                        {
                            cars[car]["mileage"] += distance;
                            cars[car]["fuel"] -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        if (cars[car]["mileage"] >= 100000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                        break;

                        case "Refuel":

                        int refill = int.Parse(tokens[2]);
                        int oldCarTank = cars[car]["fuel"];

                        if (oldCarTank + refill > 75)
                        {
                            refill = 75 - oldCarTank;
                        }

                        cars[car]["fuel"] += refill;
                        Console.WriteLine($"{car} refueled with {refill} liters");
                        break;

                        case "Revert":

                        int kilometers = int.Parse(tokens[2]);

                        cars[car]["mileage"] -= kilometers;

                        if (cars[car]["mileage"] < 10000)
                        {
                            cars[car]["mileage"] = 10000;
                            command = Console.ReadLine();
                            continue;
                        }
                        
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]} kms, Fuel in the tank: {car.Value["fuel"]} lt.");
            }
        }
    }
}
