namespace _02._From_Left_to_The_Right
{
    using System;
    using System.Numerics;

    public class FromLeftToTheRight
    {
        public static void Main()
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfInputLines; i++)
            {

                string input = Console.ReadLine();
                string[] tokens = input.Split(" ");
                long firstNumber = long.Parse(tokens[0]);
                long secondNumber = long.Parse(tokens[1]);

                long sumDigits = 0;


                if (firstNumber > secondNumber)
                {
                    long currentNumber = firstNumber;

                    while (currentNumber != 0)
                    {
                        sumDigits += currentNumber % 10;
                        currentNumber /= 10;
                    }

                    Console.WriteLine($"{Math.Abs(sumDigits)}");
                }
                else
                {
                    long currentNumber = secondNumber;

                    while (currentNumber != 0)
                    {
                        sumDigits += currentNumber % 10;
                        currentNumber /= 10;
                    }

                    Console.WriteLine($"{Math.Abs(sumDigits)}");
                }
            }
        }
    }
}