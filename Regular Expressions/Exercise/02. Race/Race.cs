namespace _02._Race
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Race
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Dictionary<string, int> racers = new Dictionary<string, int>();

            for (int i = 0; i < names.Length; i++)
            {
                racers.Add(names[i], 0);
            }

            string racerInfo = Console.ReadLine();

            while (racerInfo != "end of race")
            {
                string pattern = @"(?<name>[A-Za-z]+)|(?<distance>\d)";


                MatchCollection nameDistance = Regex.Matches(racerInfo, pattern);

                string name = "";

                int splitDigits = 0;

                foreach (Match item in nameDistance)
                {
                    foreach (Char letter in item.Groups["name"].Value)
                    {
                        name += letter;
                    }

                    foreach (Char digit in item.Groups["distance"].Value)
                    {
                        splitDigits += int.Parse(item.Groups["distance"].Value);
                    }
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += splitDigits;
                }

                racerInfo = Console.ReadLine();
            }

            int place = 1;

            foreach (KeyValuePair<string, int> racer in racers.OrderByDescending(x => x.Value).Take(3))
            {
                string position = place == 1 ? "st" : place == 2 ? "nd" : "rd";
                string racerName = racer.Key;

                Console.WriteLine($"{place}{position} place: {racerName}");

                place++;
            }
        }
    }
}