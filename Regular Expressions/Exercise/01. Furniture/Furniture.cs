namespace _01._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Furniture
    {
        public static void Main()
        {
            string pattern = @">>(?<furnitureName>([A-Za-z]+))<<(?<price>(\d+.?\d*))!(?<quantity>\d*)";

            string input = Console.ReadLine();

            List<string> furnitures = new List<string>();

            decimal totalSpentMoney = 0;

            while (input != "Purchase")
            {

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string currentFurnitureName = match.Groups["furnitureName"].Value;
                    decimal currentPrice = decimal.Parse(match.Groups["price"].Value);
                    int currentQuantity = int.Parse(match.Groups["quantity"].Value);

                    totalSpentMoney += currentQuantity * currentPrice;

                    furnitures.Add(currentFurnitureName);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (String furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: { totalSpentMoney:f2}");
        }
    }
}