namespace _06._Even_and_Odd_Subtraction
{
    using System;
    using System.Linq;

    public class EvenAndOddSubtraction
    {
        public static void Main()
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbersSum += currentNumber;
                }
                else
                {
                    oddNumbersSum += currentNumber;
                }
            }

            int difference = evenNumbersSum - oddNumbersSum;

            Console.WriteLine(difference);
        }
    }
}