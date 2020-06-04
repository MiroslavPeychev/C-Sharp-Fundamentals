namespace _04._Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Students
    {
        public static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> ouRClass = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                Student student = new Student();
                string[] splittedInput = Console.ReadLine().Split(" ");
                student.FirstName = splittedInput[0];
                student.LastName = splittedInput[1];
                student.Grade = double.Parse(splittedInput[2]);
                ouRClass.Add(student);
            }

            foreach (Student student in ouRClass.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}