namespace _04._Tribonacci_Sequence
{
    using System;

    public class TribonacciSequence
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(Tribonacci(i) + " ");
            }
        }

        public static long Tribonacci(int number)
        {
            long firstNum = 1;
            long secondNum = 1;
            long thirdNum = 2;

            for (int i = 1; i < number; i++)
            {
                long temp = firstNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = temp + firstNum + secondNum;
            }

            return firstNum;
        }
    }
}