namespace _06._Equal_Sum
{
    using System;
    using System.Linq;

    public class EqualSum
    {
        public static void Main()
        {
            int[] numbers = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int leftSum = 0;
            int rightSum = numbers.Sum();
            bool areEqual = false;
            int indexOfequality = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    indexOfequality = i;
                    areEqual = true;
                    break;
                }

                leftSum += numbers[i];
            }

            if (!areEqual)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(indexOfequality);
            }
        }
    }
}