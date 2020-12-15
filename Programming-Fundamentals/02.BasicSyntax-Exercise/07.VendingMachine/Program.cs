using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalAmount = 0;

            while (command != "Start")
            {
                double coinsInserted = double.Parse(command); // Parse-ваме към команд, защото то                                          е стринг по идея, а ние въвеждаме числа
                if (coinsInserted == 0.1 || coinsInserted == 0.2 || coinsInserted == 0.5 || coinsInserted == 1 || coinsInserted == 2)
                {
                    totalAmount += coinsInserted;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinsInserted}");
                }

                command = Console.ReadLine(); // Връщаме отново към командата, за да не е безкраен                                                                      цикълът ни
            }
            string product = Console.ReadLine();
            
            while (product != "End")
            {
                double price = 0;

                if (product == "Nuts")
                {
                    price = 2.0;
                }
                else if (product == "Water")
                {
                    price = 0.7;
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                }
                else if (product == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine(); //Слагаме и тук продуктът да се чете от конзолата, за да можем да прочетем нов продукт, когато се върнем в началото на цикъла, защото операторът countinue ни връща в началото на цикъла и пропуска долната част от иф-проверките и цикълът става безкраен, повтаряйки "Invalid product"
                    continue; // използваме оператор continue, за да се върнем в началото на цикъла иначе въпреки, че принтираме инвалид продукт продължаваме към иф-проверките и понеже се спазва условието за цената принтираме името на продукта, който е невалиден и това ни прави грешна задачата, защото не трябва да принтираме невалидните продукти.
                }
                if (totalAmount >= price)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    totalAmount -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalAmount:f2}");
        }
    }
}
