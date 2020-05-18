namespace _01._Sign_of_Integer_Numbers
{
    using System;

    public class SignOfIntegerNumbers
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintSign(inputNumber);
        }

        public static void PrintSign(int inputNumber)
        {
            string output = string.Empty;

            if (inputNumber > 0)
            {
                output = $"The number {inputNumber} is positive.";
            }
            else if (inputNumber < 0)
            {
                output = $"The number {inputNumber} is negative.";
            }
            else
            {
                output = $"The number {inputNumber} is zero.";
            }

            Console.WriteLine(output);
        }
    }
}