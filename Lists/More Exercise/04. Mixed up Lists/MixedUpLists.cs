namespace _04._Mixed_up_Lists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MixedUpLists
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            secondList.Reverse();

            var shorterList = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < shorterList; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            List<int> biggerList;

            if (shorterList == firstList.Count)
            {
                biggerList = secondList;
            }
            else
            {
                biggerList = firstList;
            }

            List<int> indexes = new List<int>();

            for (int i = shorterList; i < biggerList.Count; i++)
            {
                indexes.Add(biggerList[i]);
            }

            int startIndex = 0;
            int finalIndex = 0;

            if (indexes[0] > indexes[1])
            {
                startIndex = indexes[0];
                finalIndex = indexes[1];
            }
            else
            {
                startIndex = indexes[1];
                finalIndex = indexes[0];
            }

            List<int> finalList = new List<int>();

            for (int i = 0; i < result.Count; i++)
            {
                int currentnumber = result[i];

                if (currentnumber > finalIndex && currentnumber < startIndex)
                {
                    finalList.Add(currentnumber);
                }
            }

            finalList.Sort();

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}