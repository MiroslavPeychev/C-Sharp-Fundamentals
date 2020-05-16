namespace _03._Floating_Equality
{
    using System;

    public class FloatingEquality
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstNumber - secondNumber);
            double eps = 0.000001;
            bool areEqual = (difference <= eps);

            Console.WriteLine(areEqual);
        }
    }
}