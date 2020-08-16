namespace Travel_Company
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
       public static void Main()
        {
            var travel = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);


            while (input[0] != "ready")
            {
                string location = input[0];

                string[] tokens = input[1].Split(',');


                if (!travel.ContainsKey(location))
                {
                    travel.Add(location, new Dictionary<string, int>());
                }

                for (int i = 0; i < tokens.Length; i++)
                {
                    string[] vehiclesAndPeople = tokens[i].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string vehicle = vehiclesAndPeople[0];
                    int people = int.Parse(vehiclesAndPeople[1]);

                    if (!travel[location].ContainsKey(vehicle))
                    {
                        travel[location].Add(vehicle, people);
                    }
                    else
                    {
                        travel[location][vehicle] = people;
                    }
                }

                input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {

                string location = input[0];
                if (location == "travel")
                {
                    break;
                }

                int people = int.Parse(input[1]);

                if (travel.ContainsKey(location))
                {
                    var sum = 0;

                    var kvp = travel[location];

                    foreach (var item in kvp)
                    {
                        sum += item.Value;
                    }

                    sum -= people;

                    if (sum >= 0)
                    {
                        Console.WriteLine($"{location} -> all {people} accommodated");

                    }
                    else
                    {
                        Console.WriteLine($"{location} -> all except {Math.Abs(sum)} accommodated");

                    }

                }

                input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}