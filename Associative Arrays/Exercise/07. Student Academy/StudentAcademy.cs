namespace _07._Student_Academy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StudentAcademy
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int countOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                }

                studentGrades[name].Add(grade);
            }

            studentGrades = studentGrades
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine, studentGrades
                .Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
        }
    }
}