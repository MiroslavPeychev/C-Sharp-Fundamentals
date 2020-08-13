namespace Filter_Base
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input == "filter base")
                {
                    break;
                }
                string[] tokens = input.Split(" -> ");
                string name = tokens[0];

                int age = 0;
                double salary = 0;
                
                if(int.TryParse(tokens[1], out age))
                {
                    age = int.Parse(tokens[1]);
                    nameAge[name] = age;
                }
                else if(double.TryParse(tokens[1], out salary))
                {
                    salary = double.Parse(tokens[1]);
                    nameSalary[name] = salary;
                }
                else
                {
                    namePosition[name] = tokens[1];
                }
            }

            string command = Console.ReadLine();

            if(command == "Age")
            {
                foreach (var kvp in nameAge)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine($"====================");
                }
            }
            else if(command == "Salary")
            {
                foreach (var kvp in nameSalary)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:f2}");
                    Console.WriteLine($"====================");
                }
            }
            else if (command == "Position")
            {
                foreach (var kvp in namePosition)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine($"====================");
                }
            }
        }
    }
}