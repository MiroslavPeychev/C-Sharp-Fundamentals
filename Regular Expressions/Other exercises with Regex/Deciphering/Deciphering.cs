namespace _02._Deciphering
{
    using System;
    using System.Text.RegularExpressions;

    public class Deciphering
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] replaceString = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"[d-z#|{}]+");
            string result = "";

            Match match = regex.Match(input);

            if (input.Length != match.Length)
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {
                for (int i = 0; i < match.Length; i++)
                {
                    result += ((char)(input[i] - 3));
                }
            }

            while (result.Contains(replaceString[0]))
            {
                result = result.Replace(replaceString[0], replaceString[1]);
            }

            Console.WriteLine(result);
        }
    }
}