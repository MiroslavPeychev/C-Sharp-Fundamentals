namespace Football_League
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class FootballLeague
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());

            var pattern = string.Format(
                @"^.*(?:{0})(?<team1>[a-zA-Z]*)(?:{0}).* .*(?:{0})(?<team2>[a-zA-Z]*)(?:{0}).*(?<team1Goals>\d+):(?<team2Goals>\d+).*$", key);

            Regex regex = new Regex(pattern);
            Dictionary<string, Score> matches = new Dictionary<string, Score>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }

                Match match = regex.Match(input);

                string team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                string team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());

                int team1Goals = int.Parse(match.Groups["team1Goals"].Value);
                int team2Goals = int.Parse(match.Groups["team2Goals"].Value);

                if (!matches.ContainsKey(team1Name))
                {
                    matches[team1Name] = new Score();
                }

                if (!matches.ContainsKey(team2Name))
                {
                    matches[team2Name] = new Score();
                }

                matches[team1Name].Goals += team1Goals;
                matches[team2Name].Goals += team2Goals;

                if (team1Goals > team2Goals)
                {
                    matches[team1Name].Points += 3;
                }
                else if (team1Goals < team2Goals)
                {
                    matches[team2Name].Points += 3;
                }
                else
                {
                    matches[team1Name].Points += 1;
                    matches[team2Name].Points += 1;
                }
            }

            Console.WriteLine("League standings:");

            KeyValuePair<string, Score>[] leaguesStandings = matches
                .OrderByDescending(a => a.Value.Points)
                .ThenBy(a => a.Key)
                .ToArray();
            
            for (int i = 0; i < leaguesStandings.Length; i++)
            {
                KeyValuePair<string, Score> currentStanding = leaguesStandings[i];
                string country = currentStanding.Key;
                int points = currentStanding.Value.Points;
                int place = i + 1;
                Console.WriteLine($"{place}. {country} {points}");
            }

            Console.WriteLine("Top 3 scored goals:");

            var top3Goals = matches
                .OrderByDescending(a => a.Value.Goals)
                .ThenBy(a => a.Key)
                .Take(3)
                .ToArray();

            foreach (KeyValuePair<string, Score> pair in top3Goals)
            {
                string country = pair.Key;
                int goals = pair.Value.Goals;

                Console.WriteLine($"- {country} -> {goals}");
            }

        }
    }

    class Score
    {
        public int Points { get; set; }
        public int Goals { get; set; }
    }
}
