namespace Shellbound
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var home = new Dictionary<string, List<int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Aggregate")
                {
                    break;
                }

                string[] tokens = input.Split();
                string location = tokens[0];
                int shells = int.Parse(tokens[1]);

                if (!home.ContainsKey(location))
                {
                    home.Add(location, new List<int>());
                }

                if (!home[location].Contains(shells))
                {
                    home[location].Add(shells);
                }
            }

            foreach (var kvp in home)
            {
                string location = kvp.Key;
                List<int> shells = kvp.Value;

                var average = shells.Average();
                var sum = shells.Sum();
                var result = Math.Ceiling(sum - average);
                Console.WriteLine($"{location} -> {string.Join(", ", shells)} ({result})");
            }
        }
    }
}