namespace SoftUni_Coffee_Supplies
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var typeAndNames = new Dictionary<string, string>();
            var typeAndQuantity = new Dictionary<string, long>();

            string[] delimeters = Console.ReadLine().Split();
            string firstDelimeter = delimeters[0];
            string secondDelimeter = delimeters[1];

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of info")
                {
                    break;
                }

                if (input.Contains(firstDelimeter))
                {
                    string[] tokens = input.Split(new string[] { delimeters[0] }, StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    string type = tokens[1];

                    if (!typeAndNames.ContainsKey(name))
                    {
                        typeAndNames.Add(name, type);
                    }

                    if (!typeAndQuantity.ContainsKey(type))
                    {
                        typeAndQuantity[type] = 0;
                    }
                }
                else if (input.Contains(secondDelimeter))
                {
                    string[] tokens = input.Split(new string[] { delimeters[1] }, StringSplitOptions.RemoveEmptyEntries);
                    string type = tokens[0];
                    long quantity = long.Parse(tokens[1]);

                    if (!typeAndQuantity.ContainsKey(type))
                    {
                        typeAndQuantity[type] = quantity;
                    }
                    else
                    {
                        typeAndQuantity[type] += quantity;
                    }
                }
            }

            foreach (var item in typeAndQuantity)
            {
                if (item.Value <= 0)
                {
                    Console.WriteLine($"Out of {item.Key}");
                }
            }

            string command = Console.ReadLine();

            while (command != "end of week")
            {
                string[] tokens = command.Split();
                string name = tokens[0];
                long quantity = long.Parse(tokens[1]);

                string type = typeAndNames[name];
                typeAndQuantity[type] -= quantity;

                if (typeAndQuantity[type] <= 0)
                {
                    Console.WriteLine($"Out of {type}");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Coffee Left:");

            foreach (var kvp in typeAndQuantity.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            Console.WriteLine($"For:");

            foreach (var kvp in typeAndNames.OrderByDescending(x => x.Key).OrderBy(x => x.Value))
            {

                if (typeAndQuantity[kvp.Value] > 0)
                {
                    Console.WriteLine($"{kvp.Key} {kvp.Value}");
                }
            }
        }
    }
}