using System;

namespace _9.Volleyball
{
    class Program
    {
        static int weekends = 48;
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            int weekendsInHomePlace = int.Parse(Console.ReadLine());

            double weekendsInSofia = 0;
            double gamesInSofia = 0;
            double holidayGames = 0;
            double totalGames = 0;
            if (yearType == "normal")
            {
                weekendsInSofia = weekends - weekendsInHomePlace;
                gamesInSofia = weekendsInSofia * 3 / 4;
                holidayGames = holidays * 2 / 3;
                totalGames = gamesInSofia + weekendsInHomePlace + holidayGames;
                Console.WriteLine(Math.Floor(totalGames));
            }
            else
            {
                weekendsInSofia = weekends - weekendsInHomePlace;
                gamesInSofia = weekendsInSofia * 3 / 4;
                holidayGames = holidays * 2 / 3;
                totalGames = gamesInSofia + weekendsInHomePlace + holidayGames;
                totalGames += totalGames * 0.15;
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}
