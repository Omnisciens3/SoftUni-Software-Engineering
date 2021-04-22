using System;

namespace _01.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string vehicle = commands[1];
                double value = double.Parse(commands[2]);

                try
                {
                    if (vehicle == nameof(Car))
                    {
                        ProcessCommand(car, command, value);
                    }
                    else if (vehicle == nameof(Truck))
                    {
                        ProcessCommand(truck, command, value);
                    }
                    else
                    {
                        ProcessCommand(bus, command, value);
                    }
                }
                catch (Exception ex)
                    when (ex is InvalidOperationException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle vehicle, string command, double value)
        {
            if (command == "Drive")
            {
                vehicle.Drive(value);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {value} km");
            }
            else if (command == "DriveEmpty")
            {

                ((Bus)vehicle).DriveEmpty(value);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {value} km");

                //vehicle.Drive(value);

                //((Bus)vehicle).TurnOnAirConditioner(); //включваме си климатика след като сме карали автобуса, защото иначе трябва да направим това валидиране дали е включен или не в горната команда "Drive"  и да го включим там. А в противен случай, ако имаме отново команда ДравйЕмпти пак ще си го изключим преди да караме автобуса.
            }
            else
            {
                vehicle.Refuel(value);
            }
        }

        private static Vehicle CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumption = double.Parse(parts[2]);
            double tankCapacity = double.Parse(parts[3]);

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }

            return vehicle;
        }
    }
}
