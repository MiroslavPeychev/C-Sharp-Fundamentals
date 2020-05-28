namespace _01._Smallest_of_Three_Numbers
{
    using System;
    public class SmallestOfThreeNumbers
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallerNumber = SmallerNumber(firstNumber, secondNumber);
            int result = SmallerNumber(smallerNumber, thirdNumber);

            Console.WriteLine(result);
        }

        static int SmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber <= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }

            // return num1 <= num2 ? num1 : num2 условие после ? после ако е true връща първото ако е false второто след :
        }
    }
}