namespace _04._Refactoring_Prime_Checker
{
    using System;

    public class RefactoringPrimeChecker
    {
        public static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int number = 2; number <= endNumber; number++)
            {
                bool isPrime = true;

                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}