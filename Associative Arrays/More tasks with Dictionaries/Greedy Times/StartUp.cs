namespace Greedy_Times
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
       public static void Main()
        {
            long capacity = long.Parse(Console.ReadLine());

            var myDict = new Dictionary<string, Dictionary<string, long>>();

            myDict["Gold"] = new Dictionary<string, long>();
            myDict["Gem"] = new Dictionary<string, long>();
            myDict["Cash"] = new Dictionary<string, long>();
            long amount = 0;
            long goldAmount = 0;
            long gemAmount = 0;
            long cashAmount = 0;

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i += 2)
            {
                string key = input[i];
                long value = long.Parse(input[i + 1]);

                if (amount + value > capacity)
                {
                    continue;
                }

                if (key.ToLower() == "gold")
                {
                    if (goldAmount + value >= gemAmount)
                    {
                        if (!myDict["Gold"].ContainsKey(key))
                        {
                            myDict["Gold"][key] = 0;
                        }
                        myDict["Gold"][key] += value;
                        amount += value;
                        goldAmount += value;
                    }
                }
                
                else if (key.Length >= 4 && key.ToLower().EndsWith("gem"))
                {
                    if (gemAmount + value >= cashAmount && goldAmount>=gemAmount+value)
                    {
                        if (!myDict["Gem"].ContainsKey(key))
                        {
                            myDict["Gem"][key] = 0;
                        }

                        myDict["Gem"][key] += value;
                        amount += value;
                        gemAmount += value;
                    }
                }

                bool result = key.All(char.IsLetter);

                if (key.Length == 3 && result == true)
                {
                    if (gemAmount >= cashAmount + value)
                    {
                        if (!myDict["Cash"].ContainsKey(key))
                        {
                            myDict["Cash"][key] = 0;
                        }

                        myDict["Cash"][key] += value;

                        amount += value;
                        cashAmount += value;
                    }
                }
            }

            foreach (var item in myDict.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"<{item.Key}> ${item.Value.Values.Sum()}");
                foreach (var kvp in item.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}