namespace _08._Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] originalArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensedArray = new int[originalArray.Length - 1];

            if (originalArray.Length == 1)
            {
                Console.WriteLine(originalArray[0]);
                return;
            }

            for (int i = 0; i < originalArray.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length - i; j++)
                {
                    condensedArray[j] = originalArray[j] + originalArray[j + 1];
                }

                originalArray = condensedArray;
            }

            int condensedNumber = condensedArray[0];

            Console.WriteLine(condensedNumber);
        }
    }
}