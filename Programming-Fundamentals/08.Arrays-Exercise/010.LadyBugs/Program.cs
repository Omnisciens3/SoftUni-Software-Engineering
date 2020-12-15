using System;
using System.Linq;

namespace _010.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToArray();
            int[] field = new int[fieldSize]; // обозначаваме големината на полето.

            for (int i = 0; i < initialIndexes.Length; i++) // с него ще обходим масивът initialIndexes, за да не правим излишни ротации на цикъла, така ще вземем само местата, на които имаме калинки.
            {
                int currentIndex = initialIndexes[i];

                if (currentIndex >= 0 && currentIndex < field.Length) //правим тази проверка, за да извършим операцията, само ако сме в границите на масива - да избегнем случаи в които ни подават отрицателен индекс. -6 например.
                {
                    field[currentIndex] = 1; // така с този фор цикъл започваме да пълним индексите, на които имаме калинки и понеже масивът по дифолт е пълен с 0-ли по този начин на всеки зададен индекс ние отбелязваме, че има калинка с цифрата 1;
                }

            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split(); // така взимаме командата за движение на калинките - 0 right 1;

                int ladybugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);

                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1 || field[ladybugIndex] == 0) // за да избегнем излизане от границите на масива.
                {
                    continue; 
                }

                field[ladybugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladybugIndex + flyLength;

                    if (landIndex > field.Length -1) // ако калинката излезе извън масива.
                    {
                        continue;
                    }

                    if (field[landIndex] == 1) // ако на дадения landIndex вече има калинка.
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1; //запълваме мястото, където е кацнала калинката.
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladybugIndex - flyLength;

                    if (landIndex < 0) // пак проверяваме дали няма да излеза от границите, но в обратна посока.
                    {
                        continue;
                    }

                    if (field[landIndex] == 1) 
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1; //запълваме мястото, където е кацнала калинката.
                    }
                }
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}
