namespace _01._Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                double currentNumber = numbers[i];
                double nexNumber = numbers[i + 1];

                if (currentNumber == nexNumber)
                {
                    numbers[i] *= 2;
                    numbers.Remove(nexNumber);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}