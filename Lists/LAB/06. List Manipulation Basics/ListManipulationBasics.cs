namespace _06._List_Manipulation_Basics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ListManipulationBasics
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                string[] tokens = commandLine.Split().ToArray();
                string command = tokens[0];

                if (command == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, numberToInsert);
                }
            }
        }
    }
}