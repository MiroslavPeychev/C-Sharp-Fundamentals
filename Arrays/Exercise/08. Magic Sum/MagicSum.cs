namespace _08._Magic_Sum
{
    using System;
    using System.Linq;

    public class MagicSum
    {
        public static void Main()
        {
            int[] numbers = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];

                for (int j = i+1; j < numbers.Length; j++)
                {
                    int secondNumber = numbers[j];

                    if (firstNumber+secondNumber==magicNumber)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                    }
                }
            }
        }
    }
}