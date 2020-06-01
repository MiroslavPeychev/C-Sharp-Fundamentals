namespace _01._Count_Real_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CountRealNumbers
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (KeyValuePair<int, int> num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}