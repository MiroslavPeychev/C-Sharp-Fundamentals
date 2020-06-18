namespace _03._Big_Factorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 2; i <= inputNumber; i++)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            Console.WriteLine(factorial);
        }
    }
}