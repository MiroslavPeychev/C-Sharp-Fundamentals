namespace _07._Vending_Machine
{
    using System;

    public class VendingMachine
    {
        public static void Main()
        {
            string startOrCoin = Console.ReadLine();
            decimal totalMoney = 0;

            while (startOrCoin != "Start")
            {
                decimal coins = decimal.Parse(startOrCoin);
                switch (coins)
                {
                    case 0.1m:
                    case 0.2m:
                    case 0.5m:
                    case 1.0m:
                    case 2.0m:
                        totalMoney += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }

                startOrCoin = Console.ReadLine();
            }

            string product = string.Empty;

            while ((product = Console.ReadLine()) != "End")
            {

                decimal price = 0;

                if (product == "Coke")
                {
                    price = 1.0m;
                }
                else if (product == "Nuts")
                {
                    price = 2.0m;
                }
                else if (product == "Water")
                {
                    price = 0.7m;
                }
                else if (product == "Crisps")
                {
                    price = 1.5m;
                }
                else if (product == "Soda")
                {
                    price = 0.8m;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (totalMoney - price >= 0)
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}