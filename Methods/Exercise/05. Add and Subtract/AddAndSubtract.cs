namespace _05._Add_and_Subtract
{
    using System;

    public class AddAndSubtract
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumNumbers = SumTwoNumbers(firstNumber, secondNumber);

            int result = sumNumbers - thirdNumber;

            Console.WriteLine(result);
        }

        private static int SumTwoNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }
    }
}