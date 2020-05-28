namespace _08._Factorial_Division
{
    using System;

    public class FactorialDivision
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());//прочитаме двете числа
            int secondNumber = int.Parse(Console.ReadLine());

            long firstFactorial = Factorial(firstNumber);
            long secondFactorial = Factorial(secondNumber);

            double result = Divide(firstFactorial, secondFactorial);// делим си двата факториела

            Console.WriteLine($"{result:F2}");

        }
        private static double Divide(long num1, long num2)
        {
            return (double)num1 / num2;//кастваме си резултата към double защото от деленето на long ще получим цяло число, а се търси такова със 2 знака след запетаята.
        }
        private static long Factorial(int number)
        {
            long factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}