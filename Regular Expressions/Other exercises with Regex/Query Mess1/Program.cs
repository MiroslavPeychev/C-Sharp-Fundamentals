namespace Query_Mess1
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;


    public class Program
    {
        public static void Main()
        {
            string pattern = @"(?<key>[^\=&\?]+)=(?<value>[^\=&\?]+)";
            Regex regex = new Regex(pattern);

            while(true)
            {
                string line = Console.ReadLine();

                if(line == "END")
                {
                    break;
                }

                MatchCollection matches = regex.Matches(line);

                Dictionary<string, List<string>> keys = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups["key"].Value;
                    string value = match.Groups["value"].Value;

                    key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();

                    if (keys.ContainsKey(key) == false)
                    {
                        keys.Add(key, new List<string>());
                    }

                    keys[key].Add(value);
                }

                foreach (KeyValuePair<string, List<string>> item in keys)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}