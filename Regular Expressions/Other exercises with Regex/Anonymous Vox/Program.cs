using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<startEnd>[A-Za-z]+)(?<placeholder>.+)(\k<startEnd>)";

            string inputText = Console.ReadLine();

            List<string> placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            MatchCollection matches = Regex.Matches(inputText, pattern);

            foreach(Match matched in matches)
            {
                if(placeholders.Count>0)
                {
                    string match = matched.ToString();

                    string newBlock = matched.Groups["startEnd"].Value + placeholders[0] + matched.Groups["startEnd"].Value;

                    inputText = inputText.Replace(match, newBlock);

                    placeholders.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(inputText);

        }
    }
}
