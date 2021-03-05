using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList randomList = new RandomList();

            randomList.Add("Ceci");
            randomList.Add("Bibi");
            randomList.Add("Gishi");
            randomList.Add("Djoni");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomList.RandomString());
            }
        }
    }
}
