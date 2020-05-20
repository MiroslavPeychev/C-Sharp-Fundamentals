
namespace _10._Multiply_Evens_by_Odds
{
    using System;

     public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvensAndOdds(Math.Abs(number));

            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
         //int evenNumbersSum = GetSumOfEvenDigits(number)
         //int oddNumbersSum = GetSumOfOddDigits(number)
         // return evenNumbersSum * oddNumbersSum;
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        public static int GetSumOfEvenDigits(int number)
        {
            // int everNumbersResult = GetSumOfDigits(number, 0);
            //return everNumbersResult;
            return GetSumOfDigits(number, 0);
        }

        public static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        public static int GetSumOfDigits(int number, int expectedReemainder)
        {
            int sum = 0;

            while (number > 0)
            {
                int last = number % 10;
                number /= 10;

                if (last % 2 == expectedReemainder)
                {
                    sum += last;
                }
            }

            return sum;
        }
    }
}