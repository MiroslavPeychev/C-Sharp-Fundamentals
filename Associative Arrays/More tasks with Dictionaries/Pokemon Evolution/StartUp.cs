namespace Pokemon_Evolution
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            var myDict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] tokens = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                if (tokens.Length > 1)
                {
                    string evolution = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (!myDict.ContainsKey(name))
                    {
                        myDict.Add(name, new List<string>());
                    }
                    string toBeAdded = $"{evolution} {index}";
                    myDict[name].Add(toBeAdded);
                }
                else
                {
                    if (myDict.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var item in myDict[name])
                        {
                            string[] token = item.Split();
                            string type = token[0];
                            string index = token[1];
                            Console.WriteLine($"{type} <-> {index}");
                        }
                    }
                }
            }

            foreach (var kvp in myDict)
            {
                Console.WriteLine($"# {kvp.Key}");

                foreach (var item in kvp.Value.OrderByDescending(x => int.Parse(x.Split()[1])))
                {
                    string[] result = item.Split();
                    Console.WriteLine($"{result[0]} <-> {result[1]}");
                }
            }
        }
    }
}