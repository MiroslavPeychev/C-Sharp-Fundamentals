namespace _04._Sum_of_Chars
{
    using System;

    public class SumOfChars
    {
        public static void Main()
        {
            int numberOfImputlines = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < numberOfImputlines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                totalSum += letter;

            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}