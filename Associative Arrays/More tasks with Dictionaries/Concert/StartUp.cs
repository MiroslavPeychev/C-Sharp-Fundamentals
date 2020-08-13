namespace Concert
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var bandMembersDIctionary = new Dictionary<string, List<string>>();
            var bandTimeDictionary = new Dictionary<string, int>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                string[] commandTokens = input.Split("; ");
                string command = commandTokens[0];
                string band = commandTokens[1];

                if (command == "Play")
                {
                    int time = int.Parse(commandTokens[2]);
                    if (!bandTimeDictionary.ContainsKey(band))
                    {
                        bandTimeDictionary.Add(band, 0);
                    }

                    if (!bandMembersDIctionary.ContainsKey(band))
                    {
                        bandMembersDIctionary.Add(band, new List<string>());
                    }

                    bandTimeDictionary[band] += time;
                }
                else if (command == "Add")
                {
                    string commandTokensLeft = commandTokens[2];
                    string[] bandMembers = commandTokensLeft.Split(", ");

                    if (!bandMembersDIctionary.ContainsKey(band))
                    {
                        bandMembersDIctionary.Add(band, new List<string>());
                    }

                    if (!bandTimeDictionary.ContainsKey(band))
                    {
                        bandTimeDictionary.Add(band, 0);
                    }

                    for (int i = 0; i < bandMembers.Length; i++)
                    {
                        bandMembersDIctionary[band].Add(bandMembers[i]);
                    }
                }
            }

            int totalTime = bandTimeDictionary.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var kvp in bandTimeDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            string bandMatch = Console.ReadLine();


            if (bandMembersDIctionary.ContainsKey(bandMatch))
            {
                Console.WriteLine($"{bandMatch}");

                List<string> members = bandMembersDIctionary[bandMatch]
                    .Distinct()
                    .ToList();
                members.Distinct();

                foreach (var item in members)
                {
                    Console.WriteLine($"=> {item}");
                }
            }
        }
    }
}