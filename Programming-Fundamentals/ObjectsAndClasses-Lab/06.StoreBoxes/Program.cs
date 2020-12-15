using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split();
                int serialNumber = int.Parse(inputArgs[0]);
                string name = (inputArgs[1]);
                int quantity = int.Parse(inputArgs[2]);
                double pricePerBox = double.Parse(inputArgs[3]);
                double totalPrice = quantity * pricePerBox;

                Box currentBox = new Box(serialNumber, name, quantity, pricePerBox, totalPrice);

                boxes.Add(currentBox);
                
                input = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(x => x.TotalPrice).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PricePerBox:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:F2}");
            }
        }
    }

    class Box
    {
        public Box(int serialNumber, string item, int quantity, double pricePerBox, double totalPrice)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
            PricePerBox = pricePerBox;
            TotalPrice = totalPrice;
        }

        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double PricePerBox { get; set; }
        public double TotalPrice { get; set; }
    }
}
