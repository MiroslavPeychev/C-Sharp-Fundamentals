namespace _10._SoftUni_Exam_Results
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SoftUniExamResults
    {
        public static void Main()
        {
            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, int> userLanguage = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split('-');
                string userName = tokens[0];
                string command = tokens[1];

                if (command == "banned")
                {
                    userPoints.Remove(userName);
                }
                else
                {
                    int points = int.Parse(tokens[2]);

                    if (!userPoints.ContainsKey(userName))
                    {
                        userPoints[userName] = points;
                    }
                    else
                    {
                        if (points > userPoints[userName])
                        {
                            userPoints[userName] = points;
                        }
                    }

                    if (!userLanguage.ContainsKey(command))
                    {
                        userLanguage[command] = 0;
                    }

                    userLanguage[command]++;
                }
            }

            Console.WriteLine("Results:");

            foreach (var kvp in userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string userName = kvp.Key;
                int points = kvp.Value;
                
                Console.WriteLine($"{userName} | {points}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in userLanguage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string language = kvp.Key;
                int submissionCount = kvp.Value;

                Console.WriteLine($"{language} - {submissionCount}");
            }
        }
    }
}