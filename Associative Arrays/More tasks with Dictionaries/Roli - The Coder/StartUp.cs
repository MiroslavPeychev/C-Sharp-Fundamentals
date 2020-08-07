namespace Roli_The_Coder
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            var idAndName = new Dictionary<int, string>();
            var nameAndPart = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(tokens[0]);
                string party = tokens[1];
                List<string> participants = tokens
                    .Skip(2)
                    .ToList();                

                if(party.Contains('#'))
                {
                    if(!idAndName.ContainsKey(id))
                    {
                        idAndName.Add(id, party);
                        nameAndPart[party] = new HashSet<string>();
                    }

                    if (idAndName.ContainsKey(id) && party == idAndName[id])
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            nameAndPart[party].Add(participants[i]);
                        }                        
                    }                   
                }               
            }

            foreach (var kvp in nameAndPart.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key.Remove(0,1)} - {kvp.Value.Count()}");

                List<string> part = kvp.Value.ToList();
                part.Sort();

                foreach (var item in part)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}