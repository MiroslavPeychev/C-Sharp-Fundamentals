namespace _03._Chore_Wars
{
    using System;
    using System.Text.RegularExpressions;

    public class ChoreWars
    {
        public static void Main()
        {
            string dishesPattern = @"<[a-z0-9]+>";
            string housePattern = @"\[[A-Z0-9]+\]";
            string laundryPattern = @"\{.+\}";

            var dishesRegex = new Regex(dishesPattern);
            var houseRegex = new Regex(housePattern);
            var laundryRegex = new Regex(laundryPattern);
            var doingTheDishesTime = 0;
            var cleaningTheHouseTime = 0;
            var doingTheLaundryTime = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "wife is happy")
                {
                    break;
                }

                if (dishesRegex.IsMatch(input))
                {
                    var firstMatches = dishesRegex.Matches(input);
                    var currentTime = CountTime(firstMatches);
                    doingTheDishesTime += currentTime;
                }

                if (houseRegex.IsMatch(input))
                {
                    var secondMatches = houseRegex.Matches(input);
                    var currentTime = CountTime(secondMatches);
                    cleaningTheHouseTime += currentTime;
                }

                if (laundryRegex.IsMatch(input))
                {
                    var thirdMatches = laundryRegex.Matches(input);
                    var currentTime = CountTime(thirdMatches);
                    doingTheLaundryTime += currentTime;
                }
            }

            Console.WriteLine($"Doing the dishes - {doingTheDishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTheHouseTime} min.");
            Console.WriteLine($"Doing the laundry - {doingTheLaundryTime} min.");
            Console.WriteLine($"Total - {doingTheLaundryTime + doingTheDishesTime + cleaningTheHouseTime} min.");
        }

        private static int CountTime(MatchCollection firstMatches)
        {
            var time = 0;

            foreach (Match match in firstMatches)
            {
                var currentMatch = match.ToString();

                for (int i = 0; i < currentMatch.Length; i++)
                {
                    if (char.IsDigit(currentMatch[i]))
                    {
                        time += currentMatch[i] - 48;
                    }
                }
            }

            return time;
        }
    }
}