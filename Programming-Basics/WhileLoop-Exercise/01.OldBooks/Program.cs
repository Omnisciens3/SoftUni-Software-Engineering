using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();

            int numberOfBooksChecked = 0;
            bool isBookFound = false;
            string bookSearched = Console.ReadLine();
            while (bookSearched != "No More Books")
            {
                if (bookSearched == wantedBook)
                {
                    isBookFound = true;
                    break;
                }
                numberOfBooksChecked++;
                bookSearched = Console.ReadLine();
                
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {numberOfBooksChecked} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooksChecked} books.");
            }
        }
    }
}
