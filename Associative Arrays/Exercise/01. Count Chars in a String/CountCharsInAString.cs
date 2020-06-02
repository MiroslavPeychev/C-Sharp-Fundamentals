namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;

    public class CountCharsInAString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (letter != ' ')
                {
                    if (!lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter] = 1; 
                        
                    }
                    else                          
                    {
                        lettersCount[letter]++;
                    }
                }
            }

            foreach (KeyValuePair<char, int> kvp in lettersCount)
            {
                char letter = kvp.Key;
                int count = kvp.Value;

                Console.WriteLine($"{letter} -> {count}");
            }
        }
    }
}