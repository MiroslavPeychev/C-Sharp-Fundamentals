namespace _08._Company_Users
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CompanyUsers
    {
        public static void Main()
        {
            Dictionary <string, List<string>>companyAndEmployees = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split("->");

                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companyAndEmployees.ContainsKey(companyName))
                {
                    companyAndEmployees[companyName] = new List<string>();
                }

                if (!companyAndEmployees[companyName].Contains(employeeId))
                {
                    companyAndEmployees[companyName].Add(employeeId);
                }
            }

            foreach (KeyValuePair<string, List<string>> kvp in companyAndEmployees.OrderBy(x => x.Key))
            {
                string companyName = kvp.Key;
                List<string> employees = kvp.Value;

                Console.WriteLine($"{companyName}");

                foreach (var employeeId in employees)
                {
                    Console.WriteLine($"--{employeeId}");
                }
            }
        }
    }
}