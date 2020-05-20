namespace _11._Math_operations
{
    using System;

    public class MathOperations
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            var secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, @operator, secondNumber);

            Console.WriteLine(result);

        }
        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            return result;
        }
    }
}