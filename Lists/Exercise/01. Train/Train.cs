namespace _01._Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Train
    {
        public static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxWagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "end")
                {
                    break;
                }

                string[] tokens = commandLine.Split();

                string command = tokens[0];


                if (command == "Add")
                {
                    int wagonToAdd = int.Parse(tokens[1]);
                    wagons.Add(wagonToAdd);
                }
                else
                {
                    int passengersToAdd = int.Parse(tokens[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentElement = wagons[i];
                        if (currentElement + passengersToAdd <= maxWagonCapacity)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
