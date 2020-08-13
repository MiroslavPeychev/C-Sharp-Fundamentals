namespace Cubic_Assault
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {

            var myDict = new Dictionary<string, Dictionary<string, long>>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Count em all")
                {
                    break;
                }

                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string regionName = tokens[0];
                string meteorType = tokens[1];
                long count = long.Parse(tokens[2]);

                if (!myDict.ContainsKey(regionName))
                {
                    myDict[regionName] = new Dictionary<string, long>();
                }

                if (!myDict[regionName].ContainsKey(meteorType))
                {
                    myDict[regionName].Add("Green", 0);
                    myDict[regionName].Add("Red", 0);
                    myDict[regionName].Add("Black", 0);
                }

                myDict[regionName][meteorType] += count;

                if (myDict[regionName]["Green"] >= 1000000)
                {
                    myDict[regionName]["Red"] += myDict[regionName]["Green"] / 1000000;
                    myDict[regionName]["Green"] = myDict[regionName]["Green"] % 1000000;
                }

                if (myDict[regionName]["Red"] >= 1000000)
                {
                    myDict[regionName]["Black"] += myDict[regionName]["Red"] / 1000000;
                    myDict[regionName]["Red"] = myDict[regionName]["Red"] % 1000000;
                }
            }

            foreach (var item in myDict.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var kvp in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {kvp.Key} : {kvp.Value}");
                }
            }
        }
    }
}