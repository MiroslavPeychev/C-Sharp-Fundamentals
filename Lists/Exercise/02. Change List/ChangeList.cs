namespace _02._Change_List
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeList
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string inputReading = Console.ReadLine();

                if (inputReading == "end")
                {
                    break;
                }
                else
                {
                    string[] tokens = inputReading.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (tokens[0] == "Delete")
                    {
                        int toDelete = int.Parse(tokens[1]);

                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == toDelete)
                            {
                                input.Remove(input[i]);
                            }
                        }
                    }
                    else if (tokens[0] == "Insert")
                    {
                        int numberToAdd = int.Parse(tokens[1]);
                        int possition = int.Parse(tokens[2]);
                        input.Insert(possition, numberToAdd);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}