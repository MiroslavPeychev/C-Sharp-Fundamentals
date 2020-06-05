namespace _06._Replace_Repeating_Chars
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ReplaceRepeatingChars
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<char> chars = input.ToList();

            for (int i = 1; i < chars.Count; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    chars.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", chars));
        }
    }
}