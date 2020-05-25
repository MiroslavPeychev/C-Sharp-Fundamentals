namespace _05._Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> onlyPositiveNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > 0)
                {
                    onlyPositiveNumbers.Add(currentNumber);
                }
            }

            onlyPositiveNumbers.Reverse();

            if (onlyPositiveNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.Write(string.Join(" ", onlyPositiveNumbers));
            }

            Console.WriteLine();
        }
    }
}