namespace _09._Greater_of_Two_Values
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int firstInt = int.Parse(firstInput);
                    int secondInt = int.Parse(secondInput);
                    int resultInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(firstInput);
                    char secondChar = char.Parse(secondInput);
                    char resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstString = firstInput;
                    string secondString = secondInput;
                    string resultString = GetMax(firstString, secondString);
                    Console.WriteLine(resultString);
                    break;
            }
        }

        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        public static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        public static string GetMax(string first, string second)
        {
            int comparison = first.CompareTo(second);

            if (comparison > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}