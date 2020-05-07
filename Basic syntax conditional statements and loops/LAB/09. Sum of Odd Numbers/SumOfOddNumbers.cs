namespace _09._Sum_of_Odd_Numbers
{
    using System;

    public class SumOfOddNumbers
    {
        public static void Main()
        {
            int oddNumbersCount = int.Parse(Console.ReadLine());
            int sumOfOddNumbers = 0;
            int startingNumber = 1;

            for (int i = startingNumber; i < oddNumbersCount * 2; i += 2)
            {
                Console.WriteLine(i);
                sumOfOddNumbers += i;
            }

            Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}