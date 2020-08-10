namespace Sport_Cards
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

   public  class StartUp
    {
        public static void Main()
        {
            var myDict = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    var token = input.Split(new char[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (token[0] == "check")
                    {
                        string card = token[1];

                        if (myDict.ContainsKey(card))
                        {
                            Console.WriteLine($"{card} is available!");
                        }
                        else
                        {
                            Console.WriteLine($"{card} is not available!");
                        }
                    }
                    else
                    {
                        string card = token[0];
                        string sport = token[1];
                        decimal price = decimal.Parse(token[2]);

                        if (!myDict.ContainsKey(card))
                        {
                            myDict[card] = new Dictionary<string, decimal>();
                            myDict[card][sport] = price;
                        }

                        if (!myDict[card].ContainsKey(sport))
                        {
                            myDict[card][sport] = price;
                        }
                        else if (myDict[card].ContainsKey(sport))
                        {
                            myDict[card][sport] = price;
                        }
                    }
                }
            }

            foreach (var kvp in myDict.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var item in kvp.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{item.Key} - {item.Value:f2} ");
                }
            }
        }
    }
}