namespace _06._Courses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Courses
    {
        public static void Main()
        {
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(" : ");
                string course = tokens[0];
                string studentName = tokens[1];

                if (!students.ContainsKey(course))
                {
                    students[course] = new List<string>();
                }

                students[course].Add(studentName);
            }

            foreach (KeyValuePair<string, List<string>> kvp in students.OrderByDescending(x => x.Value.Count()))
            {
                string courseName = kvp.Key;
                List<string> registeredStudents = kvp.Value;

                Console.WriteLine($"{courseName}: {registeredStudents.Count}");

                foreach (string student in registeredStudents.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}