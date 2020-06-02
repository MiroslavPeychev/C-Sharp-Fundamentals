namespace _02._A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class AMinerTask
    {
        public static void Main()
        {
            Dictionary<string, int> mindedResourses = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!mindedResourses.ContainsKey(resource))
                {
                    mindedResourses.Add(resource, 0);
                }

                mindedResourses[resource] += quantity;
            }

            foreach (KeyValuePair<string, int> res in mindedResourses)
            {
                string resource = res.Key;
                int quantity = res.Value;

                Console.WriteLine($"{resource} -> {quantity}");
            }
        }
    }
}