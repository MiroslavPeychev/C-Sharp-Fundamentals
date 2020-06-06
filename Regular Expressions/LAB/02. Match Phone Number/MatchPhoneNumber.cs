namespace _02._Match_Phone_Number
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phones = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phones, pattern);
            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.ToString());
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}