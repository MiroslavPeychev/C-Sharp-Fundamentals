namespace _03._Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string inputLine = Console.ReadLine();

            MatchCollection dates = Regex.Matches(inputLine, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}