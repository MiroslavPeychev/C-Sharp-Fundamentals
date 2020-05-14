namespace _12._Refactor_Special_Numbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                int number = i;
                int sumDigit = 0;

                while (number != 0)
                {
                    sumDigit += number % 10;
                    number /= 10;
                }

                var isSpecial = sumDigit == 5 || sumDigit == 7 || sumDigit == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}