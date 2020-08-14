namespace Group_Continents_Countries_and_Cities
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            var geography = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries);

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!geography.ContainsKey(continent))
                {
                    geography.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!geography[continent].ContainsKey(country))
                {
                    geography[continent][country] = new List<string>();
                }

                if (!geography[continent][country].Contains(city))
                {
                    geography[continent][country].Add(city);
                }
            }

            foreach (var kvp in geography)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var item in kvp.Value.OrderBy(x=>x.Key))
                {
                    List<string> city = item.Value;
                    string country = item.Key;
                    city.Sort();

                    Console.Write($"  {country} -> ");
                    Console.WriteLine(string.Join(", ", city));
                }
            }
        }
    }
}