namespace _03._Rounding_Numbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];
                double roudedNumber = Math.Round(number, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(roudedNumber)}");
            }
        }
    }
}