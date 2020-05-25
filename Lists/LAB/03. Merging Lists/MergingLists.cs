namespace _03._Merging_Lists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MergingLists
    {
        public static void Main()
        {
            List<int> firstListNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondtListNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int minCount = Math.Min(firstListNumbers.Count, secondtListNumbers.Count);

            for (int i = 0; i < minCount; i++)
            {
                result.Add(firstListNumbers[i]);
                result.Add(secondtListNumbers[i]);
            }

            List<int> biggerList;

            if (minCount == firstListNumbers.Count)
            {
                biggerList = secondtListNumbers;
            }
            else
            {
                biggerList = firstListNumbers;
            }

            for (int i = minCount; i < biggerList.Count; i++)
            {
                result.Add(biggerList[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
