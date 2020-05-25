namespace _02._Gauss__Trick
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class GaussTrick
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                var first = numbers[i];
                var last = numbers[numbers.Count - 1 - i];

                var resultNumber = first + last;
                result.Add(resultNumber);
            }

            if (numbers.Count % 2 == 1)
            {
                var middleNumber = numbers[numbers.Count / 2];
                result.Add(middleNumber);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}