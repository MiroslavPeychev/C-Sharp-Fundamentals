namespace _02._Sum_Digits
{
    using System;

    public class SumDigits
    {
        public static void Main()
        {
            string inputNumberAsString = Console.ReadLine();
            int sumOfDigits = 0;

            for (int i = 0; i < inputNumberAsString.Length; i++)
            {
                int lastDigit = int.Parse(inputNumberAsString[i].ToString());

                sumOfDigits += lastDigit;
            }

            Console.WriteLine(sumOfDigits);

            //OR

            //int number = int.Parse(Console.ReadLine());
            //int sumDigits = 0;

            //number = Math.Abs(number);

            //while (number != 0)
            //{
            //    sumDigits += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine($"{sumDigits}");
        }
    }
}