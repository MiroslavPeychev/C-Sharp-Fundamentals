using System;
using System.Text.RegularExpressions;

namespace Extract_e_mails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<= )[A-Za-z0-9]+([.\-_][A-Za-z0-9]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
}
