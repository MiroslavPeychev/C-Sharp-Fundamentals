namespace _05._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            string inputLine = Console.ReadLine();

            while (inputLine!="end")
            {
                string[] tokens = inputLine.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);

                inputLine = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();
            List<Student> filteredStudents = students
                .Where(s => s.City == filterCity)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string City { get; set; }
        }
    }
}