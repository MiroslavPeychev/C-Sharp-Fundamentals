namespace _06._Middle_Characters
{
    using System;

    public class MiddleCharacter
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            string subStr;

            if (inputString.Length % 2 == 0)
            {
                subStr = inputString.Substring(inputString.Length / 2 - 1, 2);
            }
            else
            {
                subStr = inputString.Substring(inputString.Length / 2, 1);
            }

            Console.WriteLine(subStr);
        }
    }
}