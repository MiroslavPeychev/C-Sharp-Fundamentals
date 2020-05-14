namespace _02._Pounds_to_Dollars
{
    using System;

    public class PoundsToDollars
    {
        public static void Main()
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            //1 British Pound = 1.31 Dollars

            decimal dollars = pounds * 1.31m;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}