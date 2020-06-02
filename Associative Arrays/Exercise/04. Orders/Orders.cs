namespace _04._Orders
{
    using System;
    using System.Collections.Generic;

    public class Orders
    {
        public static void Main()
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();
            Dictionary<string, decimal> productQuantity = new Dictionary<string, decimal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] tokens = input.Split();
                string productName = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                decimal quantity = decimal.Parse(tokens[2]);

                if (!productPrice.ContainsKey(productName))
                {
                    productQuantity[productName] = quantity;
                }
                else
                {
                    productQuantity[productName] += quantity;
                }

                productPrice[productName] = price;
            }

            foreach (KeyValuePair<string, decimal> kvp in productQuantity)
            {
                string product = kvp.Key;
                decimal quantity = kvp.Value;
                decimal price = productPrice[product];
                decimal totalPrice = quantity * price;

                Console.WriteLine($"{product} -> {totalPrice:f2}");
            }
        }
    }
}