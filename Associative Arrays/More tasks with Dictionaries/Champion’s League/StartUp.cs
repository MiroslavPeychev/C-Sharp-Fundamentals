namespace Champion_s_League
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var opponents = new Dictionary<string, HashSet<string>>();
            var wins = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                var tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string firstTeam = tokens[0];
                string secondTeam = tokens[1];
                var firstMatch = tokens[2].Split(':');
                int firstTeamGoalsFirstMatch = int.Parse(firstMatch[0]);
                int secondTeamGoalsFirstMatch = int.Parse(firstMatch[1]);
                var secondMatch = tokens[3].Split(':');
                int secondTeamGoalsSecondMatch = int.Parse(secondMatch[0]);
                int firstTeamGoalsSecondMatch = int.Parse(secondMatch[1]);

                if (!opponents.ContainsKey(firstTeam))
                {
                    opponents[firstTeam] = new HashSet<string>();
                    wins[firstTeam] = 0;
                }

                if (!opponents.ContainsKey(secondTeam))
                {
                    opponents[secondTeam] = new HashSet<string>();
                    wins[secondTeam] = 0;
                }

                if (firstTeamGoalsFirstMatch + firstTeamGoalsSecondMatch == secondTeamGoalsFirstMatch + secondTeamGoalsSecondMatch)
                {
                    if (firstTeamGoalsFirstMatch + firstTeamGoalsSecondMatch * 2 < secondTeamGoalsFirstMatch * 2 + secondTeamGoalsSecondMatch)
                    {
                        opponents[secondTeam].Add(firstTeam);
                        opponents[firstTeam].Add(secondTeam);
                        wins[secondTeam] += 1;
                    }
                    else if (firstTeamGoalsFirstMatch + firstTeamGoalsSecondMatch * 2 > secondTeamGoalsFirstMatch * 2 + secondTeamGoalsSecondMatch)
                    {
                        opponents[firstTeam].Add(secondTeam);
                        opponents[secondTeam].Add(firstTeam);
                        wins[firstTeam] += 1;
                    }
                }
                else if (firstTeamGoalsSecondMatch + firstTeamGoalsFirstMatch < secondTeamGoalsFirstMatch + secondTeamGoalsSecondMatch)
                {
                    opponents[firstTeam].Add(secondTeam);
                    opponents[secondTeam].Add(firstTeam);
                    wins[secondTeam] += 1;

                }
                else if (firstTeamGoalsSecondMatch + firstTeamGoalsFirstMatch > secondTeamGoalsFirstMatch + secondTeamGoalsSecondMatch)
                {
                    opponents[secondTeam].Add(firstTeam);
                    opponents[firstTeam].Add(secondTeam);
                    wins[firstTeam] += 1;
                }

            }

            foreach (var item in wins.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"- Wins: {item.Value}");
                var those = opponents[item.Key].OrderBy(x => x);
                Console.WriteLine($"- Opponents: {string.Join(", ", those)}");
            }
        }
    }
}