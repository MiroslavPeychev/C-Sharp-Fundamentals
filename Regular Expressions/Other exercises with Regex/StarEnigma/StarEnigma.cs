namespace StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class StarEnigma
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Regex starReg = new Regex(@"[sSTtaArR]");
            Regex messageRegex = new Regex(@"[^@\-:!>]*@(?<name>[A-Za-z]+)[^@\-:!>]*:(\d+)[^@\-:!>]*!(?<type>A|D)![^@\-:!>]*->(\d+)[^@\-:!>]*");
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                MatchCollection starMatches = starReg.Matches(inputLine);
                int step = starMatches.Count;
                StringBuilder decMessage = new StringBuilder();

                for (int j = 0; j < inputLine.Length; j++)
                {
                    char current = (char)(inputLine[j] - step);
                    decMessage.Append(current);
                }

                if (messageRegex.IsMatch(decMessage.ToString()))
                {
                    Match match = messageRegex.Match(decMessage.ToString());
                    string type = match.Groups["type"].Value;
                    string name = match.Groups["name"].Value;

                    if (type == "D")
                    {
                        destroyed.Add(name);
                    }
                    else if (type == "A")
                    {
                        attacked.Add(name);
                    }

                }

                Console.WriteLine($"Attacked planets: {attacked.Count}");
                foreach (var item in attacked.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }

                Console.WriteLine($"Destroyed planets: {destroyed.Count}");
                foreach (var item in destroyed.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}