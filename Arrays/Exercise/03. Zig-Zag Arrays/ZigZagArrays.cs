namespace _03._Zig_Zag_Arrays
{
    using System;
    using System.Linq;

    public class ZigZagArrays
    {
        public static void Main()
        {
            int inputLinesCount = int.Parse(Console.ReadLine());

            int[] firstArray = new int[inputLinesCount];
            int[] secondArray = new int[inputLinesCount];

            for (int i = 0; i < inputLinesCount; i++)
            {
                int[] numbers = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i%2==0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}