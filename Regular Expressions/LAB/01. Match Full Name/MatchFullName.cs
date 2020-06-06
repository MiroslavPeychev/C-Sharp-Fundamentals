namespace _01._Match_Full_Name
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            string pattern = @"\b(?<firstName>[A-Z]{1}[a-z]{1,}) (?<familyName>[A-Z]{1}[a-z]{1,})\b";
            //string pattern = @"\b(?<firstName>[A-Z]{1}[a-z]+) (?<familyName>[A-Z]{1}[a-z]+)";

            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, pattern);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                result.Append(match + " ");
            }

            Console.WriteLine(result.ToString());
        }
    }
}