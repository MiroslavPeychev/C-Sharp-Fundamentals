namespace _03._Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    public class WordSynonyms
    {
        public static void Main()
        {
            int totalWordsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < totalWordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonymous = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                
                List<string> synonyms = words[word];
                synonyms.Add(synonymous);
            }

            foreach (KeyValuePair<string, List<string>> kvp in words)
            {
                string word = kvp.Key;
                List<string> synonyms = kvp.Value;

                Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
            }
        }
    }
}