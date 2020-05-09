namespace _03._Gaming_Store
{
    using System;

    public class GamingStore
    {
        public static void Main()
        {
            double cashAvailable = double.Parse(Console.ReadLine());

            double totalMoneySpent = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }

                double gamePrice = 0;

                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (gamePrice > cashAvailable)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    cashAvailable -= gamePrice;
                    totalMoneySpent += gamePrice;
                }

                Console.WriteLine($"Bought {game}");

                if (cashAvailable == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalMoneySpent:f2}. Remaining: ${cashAvailable:f2}");
        }
    }
}