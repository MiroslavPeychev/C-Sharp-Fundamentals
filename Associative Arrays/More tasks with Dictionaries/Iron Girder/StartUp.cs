namespace Iron_Girder
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var townTime = new Dictionary<string, int>();
            var townPeople = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Slide rule")
                {
                    break;
                }

                string[] inputTokens = input.Split(':');
                string townName = inputTokens[0];

                string[] tokens = inputTokens[1].Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                int time = 0;

                if (int.TryParse(tokens[0], out time))
                {
                    time = int.Parse(tokens[0]);
                    long passangers = long.Parse(tokens[1]);

                    if (!townTime.ContainsKey(townName))
                    {
                        townTime.Add(townName, time);
                        townPeople.Add(townName, 0);
                    }
                    else if (townTime.ContainsKey(townName))
                    {
                        if (townTime[townName] > time || townTime[townName] == 0)
                        {
                            townTime[townName] = time;
                        }
                    }

                    townPeople[townName] += passangers;
                }
                else
                {
                    long passangers = long.Parse(tokens[1]);

                    if (townTime.ContainsKey(townName))
                    {
                        townPeople[townName] -= passangers;
                        townTime[townName] = 0;
                    }
                }
            }

            foreach (var kvp in townTime.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (kvp.Value != 0 && townPeople[kvp.Key] != 0)
                {
                    Console.WriteLine($"{kvp.Key} -> Time: {kvp.Value} -> Passengers: {townPeople[kvp.Key]}");
                }
            }
        }
    }
}