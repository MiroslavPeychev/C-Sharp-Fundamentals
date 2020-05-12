namespace _04._Array_Rotation
{
    using System;
    using System.Linq;

    public class ArrayRotation
    {
        public static void Main()
        {
            int[] numbers = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations % numbers.Length; i++)
            {
                int tempFirst = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = tempFirst;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}