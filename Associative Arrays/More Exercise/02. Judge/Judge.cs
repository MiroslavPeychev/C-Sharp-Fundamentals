namespace _02._Judge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Judge
    {
        public static void Main()
        {
            var judge = new Dictionary<string, Dictionary<string, int>>();
            var students = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ");
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!judge.ContainsKey(contest))
                {
                    judge.Add(contest, new Dictionary<string, int>());
                }

                if (!judge[contest].ContainsKey(username))
                {
                    judge[contest].Add(username, points);


                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, points);
                    }
                    else
                    {
                        students[username] += points;
                    }
                }
                else
                {
                    if (judge[contest][username] < points)
                    {
                        students[username] += points - judge[contest][username];
                        judge[contest][username] = points;
                    }
                }
            }

            foreach (var kvp in judge)
            {
                string constestName = kvp.Key;
                int numberOfParticipants = kvp.Value.Count;

                Console.WriteLine($"{constestName}: {numberOfParticipants} participants");
                int position = 1;
                
                foreach (var entity in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string userName = entity.Key;
                    int userPoints = entity.Value;
                    
                    Console.WriteLine($"{position}. {userName} <::> {userPoints}");
                    position++;
                }
            }

            Console.WriteLine("Individual standings:");

            int position1 = 1;

            foreach (var student in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string userName = student.Key;
                int totalPoints = student.Value;
                
                Console.WriteLine($"{position1}. {userName} -> {totalPoints}");
                position1++;
            }
        }
    }
}