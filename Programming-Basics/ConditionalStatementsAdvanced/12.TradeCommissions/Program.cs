using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            //Град    0 ≤ s ≤ 500      500 < s ≤ 1 000      1 000 < s ≤ 10 000       s > 10 000
            //Sofia        5 %         7 %                     8 %                        12 %
            //Varna        4.5 %       7.5 %                   10 %                       13 %
            //Plovdiv      5.5 %       8 %                     12 %                       14.5 %

            if (sales > 0)
            {
                switch (city)
                {
                    case "Sofia":
                        if (sales >= 0 && sales <= 500)
                        {
                            comission = sales * 0.05;
                            Console.WriteLine($"{comission:F2}");


                        }
                        else if (sales > 500 && sales <= 1000)
                        {
                            comission = sales * 0.07;
                            Console.WriteLine($"{comission:F2}");
                        }
                        else if (sales > 1000 && sales <= 10000)
                        {
                            comission = sales * 0.08;
                            Console.WriteLine($"{comission:F2}");

                        }
                        else
                        {
                            comission = sales * 0.12;
                            Console.WriteLine($"{comission:F2}");
                        }
                        break;
                    case "Varna":
                        if (sales >= 0 && sales <= 500)
                        {
                            comission = sales * 0.045;
                            Console.WriteLine($"{comission:F2}");

                        }
                        else if (sales > 500 && sales <= 1000)
                        {
                            comission = sales * 0.075;
                            Console.WriteLine($"{comission:F2}");
                        }
                        else if (sales > 1000 && sales <= 10000)
                        {
                            comission = sales * 0.1;
                            Console.WriteLine($"{comission:F2}");

                        }
                        else
                        {
                            comission = sales * 0.13;
                            Console.WriteLine($"{comission:F2}");
                        }
                        break;
                    case "Plovdiv":
                        if (sales >= 0 && sales <= 500)
                        {
                            comission = sales * 0.055;
                            Console.WriteLine($"{comission:F2}");

                        }
                        else if (sales > 500 && sales <= 1000)
                        {
                            comission = sales * 0.08;
                            Console.WriteLine($"{comission:F2}");
                        }
                        else if (sales > 1000 && sales <= 10000)
                        {
                            comission = sales * 0.12;
                            Console.WriteLine($"{comission:F2}");

                        }
                        else
                        {
                            comission = sales * 0.145;
                            Console.WriteLine($"{comission:F2}");
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else
            {
                Console.WriteLine("error");
            }




        }
    }
}
