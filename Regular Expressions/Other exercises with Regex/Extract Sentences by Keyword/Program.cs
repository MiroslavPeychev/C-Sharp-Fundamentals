using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();

            string pattern = $@"\b{searchWord}\b";
            Regex regex = new Regex(pattern);

            string[] words = Console.ReadLine().Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            foreach (var word in words)
            {
                if(regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
