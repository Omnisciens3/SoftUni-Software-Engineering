using System;
using System.Linq;

namespace _08.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            int room = 0;

            string[] dungeons = Console.ReadLine().Split('|').ToArray();

            for (int i = 0; i < dungeons.Length; i++)
            {
                string[] currentRoom = dungeons[i].Split();

                string command = currentRoom[0];
                int value = int.Parse(currentRoom[1]);
                room++;

                switch (command)
                {
                    case "potion":
                        health += value;
                        if (health > 100)
                        {
                            int oldHealth = health - value;
                            health = 100;
                            value = health - oldHealth;
                        }
                        Console.WriteLine($"You healed for {value} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += value;
                        Console.WriteLine($"You found {value} bitcoins.");
                        break;
                    default:
                        health -= value;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {room}");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        break;
                }
            }
            Console.WriteLine($"You've made it!\nBitcoins: {bitcoins}\nHealth: {health}");
           
        }
    }
}
