namespace _04._Reverse_String
{
    using System;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed);

        }
    }
}