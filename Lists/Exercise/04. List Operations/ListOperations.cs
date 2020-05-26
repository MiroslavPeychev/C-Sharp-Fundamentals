namespace _04._List_Operations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ListOperations
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        if (indexToInsert < 0 || indexToInsert > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(indexToInsert, numberToInsert);
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(tokens[1]);
                        if (indexToRemove < 0 || indexToRemove > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        break;
                    case "Shift":
                        string direction = tokens[1];
                        int rotations = int.Parse(tokens[2]);

                        if (direction == "left")
                        {
                            for (int i = 0; i < rotations % numbers.Count; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.Add(firstNum);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rotations % numbers.Count; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.Insert(0, lastNum);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}