namespace _07._Equal_Arrays
{
    using System;
    using System.Linq;

    public class EqualArrays
    {
        public static void Main()
        {
            int[] firstArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstArraySum = 0;
            bool areIdentical = true;

            for (int i = 0; i < firstArray.Length; i++)
            {

                if (firstArray[i] != secondArray[i])
                {
                    areIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    firstArraySum += firstArray[i];
                }
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {firstArraySum}");
            }
        }
    }
}