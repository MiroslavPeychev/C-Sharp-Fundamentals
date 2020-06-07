namespace _03._SoftUni_Bar_Income
{
    using System;
    using System.Text.RegularExpressions;

    public class SoftUniBarIncome
    {
        public static void Main()
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+)\$";
            double totalIncome = 0;

            while (true)
            {
                string inputLines = Console.ReadLine();

                if (inputLines == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(inputLines, pattern))
                {
                    Match match = Regex.Match(inputLines, pattern);
                    string customerName = match.Groups["customer"].Value;
                    string productName = match.Groups["product"].Value;
                    int productQuantity = int.Parse(match.Groups["count"].Value);
                    double productPrice = double.Parse(match.Groups["price"].Value);
                    double customerBill = productQuantity * productPrice;

                    Console.WriteLine($"{customerName}: {productName} - {customerBill:f2}");

                    totalIncome += customerBill;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}