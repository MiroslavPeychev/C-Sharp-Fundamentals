namespace _09._Palindrome_Integers
{
    using System;

    public class PalindromeIntegers
    {
        public static void Main()
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "END")
                {
                    break;
                }

                string reversedWord = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                bool isPalindrome = IsPalindrome(word, reversedWord);

                Console.WriteLine(isPalindrome == true ? "true" : "false");
            }
        }

        private static bool IsPalindrome(string word, string reversedWord)
        {
            return word == reversedWord;
        }
    }
}