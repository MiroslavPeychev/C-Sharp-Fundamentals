namespace _06._Strong_number
{
    using System;

    public class StrongNumber
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int numberCopy = inputNumber;
            int sumFactorials = 0;

            while (inputNumber != 0)
            {
                int currentNumber = inputNumber % 10;
                inputNumber /= 10;

                int factorial = 1;

                for (int i = 2; i <= currentNumber; i++)
                {
                    factorial *= i;
                }

                sumFactorials += factorial;
            }

            if (sumFactorials == numberCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}