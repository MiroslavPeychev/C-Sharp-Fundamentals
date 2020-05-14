namespace _09._Chars_to_String
{
    using System;

    public class CharsToString
    {
        public static void Main()
        {
            string result = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                result += Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }
}