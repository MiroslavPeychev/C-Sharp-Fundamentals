
namespace _02._Mirror_Words
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class MirrorWods
    {
        public static void Main()
        {
            string pattern = @"([#]|@)(?<firstWord>[A-z]{3,})\1{2}(?<secondWord>[A-z]{3,})\1";

            string inputLine = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputLine, pattern);
            List<string> mirrorWords = new List<string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                string reversed = ReverseString(secondWord);
                bool areEqual = firstWord.Equals(reversed);

                if (areEqual)
                {
                    string result = $"{firstWord} <=> {secondWord}";
                    mirrorWords.Add(result);
                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                int validPairsCount = matches.Count;
                Console.WriteLine($"{validPairsCount} word pairs found!");
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}