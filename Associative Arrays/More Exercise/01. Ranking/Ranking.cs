namespace _01._Ranking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Ranking
    {
        public static void Main()
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] tokens = input.Split(':').ToArray();
                string contest1 = tokens[0];
                string password1 = tokens[1];

                contestAndPassword[contest1] = password1;

                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> contestAndUser = new Dictionary<string, Dictionary<string, int>>();
            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>").ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == password)
                {
                    if (!contestAndUser.ContainsKey(username))
                    {
                        contestAndUser.Add(username, new Dictionary<string, int>());
                        contestAndUser[username].Add(contest, points);
                    }
                    else
                    {
                        if (contestAndUser[username].ContainsKey(contest))
                        {
                            if (contestAndUser[username][contest] < points)
                            {
                                contestAndUser[username][contest] = points;
                            }

                        }
                        else
                        {
                            contestAndUser[username].Add(contest, points);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> userScore = contestAndUser
                .OrderByDescending(x => x.Value.Values.Sum())
                .Take(1)
                .ToDictionary(x=>x.Key, x=>x.Value);

            string name = string.Empty;
            int sum = 0;

            foreach (var kvp in userScore)
            {
                name = kvp.Key;

                foreach (var score in kvp.Value)
                {
                    sum += score.Value;
                }
            }

            Console.WriteLine($"Best candidate is {name} with total {sum} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvp in contestAndUser.OrderBy(x => x.Key))
            {
                string userName = kvp.Key;
                
                Console.WriteLine($"{userName}");

                foreach (var kvp1 in kvp.Value.OrderByDescending(x => x.Value))
                {
                    string contest = kvp1.Key;
                    int points = kvp1.Value; 
                    
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}