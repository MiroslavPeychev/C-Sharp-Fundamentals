namespace _03._Exact_Sum_of_Real_Numbers
{
    using System;

    public class ExactSumOfRealNumbers
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < inputNumber; i++)
            {
                decimal numberToSum = decimal.Parse(Console.ReadLine());
                sum += numberToSum;
            }

            Console.WriteLine(sum);
        }
    }
}