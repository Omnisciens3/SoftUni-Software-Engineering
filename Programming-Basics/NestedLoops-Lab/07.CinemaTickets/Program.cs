using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStandartTickets = 0;
            int totalStudentTickets = 0;
            int totalKidsTickets = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                

                if (movie == "Finish")
                {
                    break;
                }
                int freeSpots = int.Parse(Console.ReadLine());
                int ticketsForMovie = 0;
                int totalFreeSpots = freeSpots; // за да можем да запазим началния стадий, защото по-надолу го намаляваме при всяка стъпка.

                while (freeSpots > 0)
                {
                    string currentTicket = Console.ReadLine();

                    if (currentTicket == "End")
                    {
                        break;
                    }

                    switch (currentTicket)
                    {
                        case "standard":
                            totalStandartTickets++;
                            break;
                             case "student":
                            totalStudentTickets++;
                            break;
                             case "kid":
                            totalKidsTickets++;
                            break;
                    }
                    ticketsForMovie++;
                    freeSpots--;
                }
                double capacity = ticketsForMovie * 1.0 / totalFreeSpots * 100;
                Console.WriteLine($"{movie} - {capacity:f2}% full.");
            }
            int totalTickets = totalStudentTickets + totalStandartTickets + totalKidsTickets;

            double averageStudentTickets = totalStudentTickets * 1.0 / totalTickets * 100;
            double averageStandartTickets = totalStandartTickets * 1.0 / totalTickets * 100;
            double averageKidsTickets = totalKidsTickets * 1.0 / totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{averageStudentTickets:F2}% student tickets.");
            Console.WriteLine($"{averageStandartTickets:F2}% standard tickets.");
            Console.WriteLine($"{averageKidsTickets:F2}% kids tickets.");
        }
    }
}
