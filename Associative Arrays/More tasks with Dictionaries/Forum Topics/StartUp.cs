namespace Forum_Topics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var topics = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "filter")
                {
                    break;
                }

                string[] tokens = input.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];
                string[] tags = tokens[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!topics.ContainsKey(topic))
                {
                    topics.Add(topic, new List<string>());
                }

                foreach (var tag in tags)
                {
                    if (!topics[topic].Contains(tag))
                    {
                        topics[topic].Add(tag);
                    }
                }
            }

            string[] final = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var kvp in topics)
            {
                if(final.All(x=>kvp.Value.Contains(x)))
                {
                    List<string> result = kvp.Value.Select(x=> "#" + x).ToList();
                    Console.WriteLine($"{kvp.Key} | {string.Join(", ", result)}");
                }
            }
        }
    }
}