namespace _05._Top_Integers
{
    using System;
    using System.Linq;

    public class TopIntegers
    {
        public static void Main()
        {
            int[] numbers = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int lastNumber = numbers[numbers.Length - 1];//Last number is always topInteger

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];

                bool isTopInteger = true;

                for (int j = i + 1; j <= numbers.Length-1; j++)
                {
                    int numberToCompare = numbers[j];

                    if (currentNumber <= numberToCompare)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine(lastNumber);
        }
    }
}