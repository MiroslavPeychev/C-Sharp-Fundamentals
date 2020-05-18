namespace _05._Orders
{
    using System;

    public class Orders
    {
        public static void Main()
        {
            string productType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            switch (productType)
            {
                case "coffee":
                    FinalPrice(price = 1.50, quantity);
                    break;
                case "water":
                    FinalPrice(price = 1.00, quantity);
                    break;
                case "coke":
                    FinalPrice(price = 1.40, quantity);
                    break;
                case "snacks":
                    FinalPrice(price = 2.00, quantity);
                    break;
            }
        }

        public static void FinalPrice(double price, int quantity)
        {
            Console.WriteLine($"{(price * quantity):f2}");
        }
    }
}