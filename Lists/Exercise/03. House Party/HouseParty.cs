namespace _03._House_Party
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class HouseParty
    {
        public static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> goingToTheParty = new List<string>();
            string name = string.Empty;
            int count = 0;

            while (numberOfCommands > count)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                name = commands[0];

                if (commands.Length == 3)
                {
                    if (goingToTheParty.Contains(commands[0]))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        goingToTheParty.Add(name);
                    }
                }
                else if (commands.Length == 4)
                {
                    if (goingToTheParty.Contains(name))
                    {
                        goingToTheParty.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

                count++;
            }

            Console.WriteLine(string.Join(Environment.NewLine, goingToTheParty));
        }
    }
}