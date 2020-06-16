namespace Extract_Sentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string searchWord = Console.ReadLine();

            string pattern = $@"\b{searchWord}\b";
            Regex regex = new Regex(pattern);

            string[] words = Console.ReadLine()
                .Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            foreach (string word in words)
            {
                if(regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}