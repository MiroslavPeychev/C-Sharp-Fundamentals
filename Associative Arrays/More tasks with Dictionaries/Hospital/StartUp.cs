namespace Hospital
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var department = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Output")
                {
                    break;
                }

                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var deparmentString = tokens[0];
                var doctorString = $"{tokens[1]} {tokens[2]}";
                var patient = tokens[3];

                if (!department.ContainsKey(deparmentString))
                {
                    department[deparmentString] = new List<string>();
                }

                department[deparmentString].Add(patient);

                if (!doctors.ContainsKey(doctorString))
                {
                    doctors[doctorString] = new List<string>();
                }

                doctors[doctorString].Add(patient);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var tokens = input.Split();

                if (tokens.Length == 1)
                {
                    foreach (var item in department[tokens[0]])
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (int.TryParse(tokens[1], out int result))
                {
                    if (int.Parse(tokens[1]) > 20)
                    {
                        continue;
                    }

                    string where = tokens[0];
                    int room = int.Parse(tokens[1]);

                    foreach (var item in department[where].Skip(3 * (room - 1)).Take(3).OrderBy(x => x))
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    string doctor = $"{tokens[0]} {tokens[1]}";
                    doctors[doctor].Sort();
                    Console.WriteLine(string.Join(Environment.NewLine, doctors[doctor]));
                }
            }
        }
    }
}