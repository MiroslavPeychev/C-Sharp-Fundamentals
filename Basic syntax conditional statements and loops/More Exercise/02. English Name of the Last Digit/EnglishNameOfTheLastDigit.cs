namespace _02._English_Name_of_the_Last_Digit
{
    using System;

    public class EnglishNameOfTheLastDigit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberAsAString = ReturneName(number);

            Console.WriteLine(numberAsAString);
        }

        private static string ReturneName(int number)
        {
            string result = string.Empty;

            int lastDigit = number % 10;

            switch (lastDigit)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}