namespace _02._Print_Numbers_in_Reverse_Order
{
    using System;

    public class PrintNumbersInReverseOrder
    {
        public static void Main()
        {
            int numberOfinputLines = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfinputLines];

            for (int i = 0; i < numberOfinputLines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} "); //Print numbers from last to first
            }
        }
    }
}