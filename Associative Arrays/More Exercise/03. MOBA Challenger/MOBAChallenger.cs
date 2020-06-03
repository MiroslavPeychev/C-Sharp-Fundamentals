namespace _03._MOBA_Challenger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MOBAChallenger
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> points = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                string[] delimeters = { " -> ", " vs " };
                string[] tokens = input
                    .Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    string firstPlayerName = tokens[0];
                    string secondPlayerName = tokens[1];

                    if (players.ContainsKey(firstPlayerName) && players.ContainsKey(secondPlayerName))
                    {
                        bool hasToBreak = false;

                        foreach (var entity in players[firstPlayerName])
                        {
                            foreach (var entity1 in players[secondPlayerName])
                            {
                                if (entity.Key == entity1.Key)
                                {
                                    hasToBreak = true;
                                    break;
                                }
                            }

                            if (hasToBreak)
                            {
                                break;
                            }
                        }

                        if (hasToBreak)
                        {
                            if (points[firstPlayerName] < points[secondPlayerName])
                            {
                                players.Remove(firstPlayerName);
                                points.Remove(firstPlayerName);
                            }
                            else if (points[firstPlayerName] > points[secondPlayerName])
                            {
                                players.Remove(secondPlayerName);
                                points.Remove(secondPlayerName);
                            }
                        }
                    }
                }
                else
                {
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                    }

                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);

                        if (!points.ContainsKey(player))
                        {
                            points.Add(player, skill);
                        }
                        else
                        {
                            points[player] += skill;
                        }
                    }
                    else
                    {
                        if (players[player][position] < skill)
                        {
                            points[player] += skill - players[player][position];
                            players[player][position] = skill;
                        }
                    }
                }
            }

            foreach (var kvp in points.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string playerName = kvp.Key;
                int totalSkill = kvp.Value;
                
                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");

                foreach (var kvp2 in players[kvp.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string possition = kvp2.Key;
                    int skill = kvp2.Value;
                    
                    Console.WriteLine($"- {possition} <::> {skill}");
                }
            }
        }
    }
}