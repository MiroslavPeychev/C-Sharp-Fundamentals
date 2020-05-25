namespace _07._List_Manipulation_Advanced
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ListManipulationAdvanced
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            bool listIsChanged = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        listIsChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        listIsChanged = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        listIsChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        listIsChanged = true;
                        break;
                    case "Contains":
                        int numberToContain = int.Parse(tokens[1]);

                        if (numbers.Contains(numberToContain))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":
                        int[] isEven = numbers.Where(n => n % 2 == 0).ToArray();
                        Console.WriteLine(string.Join(" ", isEven));
                        break;
                    case "PrintOdd":
                        int[] isOdd = numbers.Where(n => n % 2 != 0).ToArray();
                        Console.WriteLine(string.Join(" ", isOdd));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        if (condition == "<")
                        {
                            int[] lowerNumbers = numbers.Where(x => x < number).ToArray();
                            Console.WriteLine(string.Join(" ", lowerNumbers));
                        }
                        else if (condition == ">")
                        {
                            int[] biggerNumber = numbers.Where(x => x > number).ToArray();
                            Console.WriteLine(string.Join(" ", biggerNumber));
                        }
                        else if (condition == "<=")
                        {
                            int[] lowerOrEqualNumbers = numbers.Where(x => x <= number).ToArray();
                            Console.WriteLine(string.Join(" ", lowerOrEqualNumbers));
                        }
                        else if (condition == ">=")
                        {
                            int[] biggerOrEqualNumbers = numbers.Where(x => x >= number).ToArray();
                            Console.WriteLine(string.Join(" ", biggerOrEqualNumbers));
                        }
                        break;
                }
            }

            if (listIsChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}