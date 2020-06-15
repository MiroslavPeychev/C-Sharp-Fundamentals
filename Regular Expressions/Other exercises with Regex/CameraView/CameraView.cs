namespace CameraView
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class CameraView
    {
        public static void Main()
        {
            string pattern = @"\|<(?<picture>\w+)";

            Regex regex = new Regex(pattern);

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();
            int skipNumber = numbers[0];
            int takeNumber = numbers[1];


            MatchCollection matches = regex.Matches(text);

            string[] allResults = new string[matches.Count];
            int index = 0;

            foreach (Match match in matches)
            {
                string currentMatch = match.Groups["picture"].Value;

                char[] resultChars = currentMatch
                    .Skip(skipNumber)
                    .Take(takeNumber)
                    .ToArray();

                string currentResult = string.Join("", resultChars);
                allResults[index] = currentResult;
                index++;
            }

            Console.WriteLine(string.Join(", ", allResults));
        }
    }
}