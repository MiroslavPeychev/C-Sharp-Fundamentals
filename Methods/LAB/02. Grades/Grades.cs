namespace _02._Grades
{
    using System;

    public class Grades
    {
        public static void PrintInWord(double grade)
        {
            string gradeInWord = string.Empty;

            if (grade >= 2 && grade <= 2.99)

                gradeInWord = "Fail";

            else if (grade >= 3 && grade <= 3.49)

                gradeInWord = "Poor";

            else if (grade >= 3.50 && grade <= 4.49)

                gradeInWord = "Good";

            else if (grade >= 4.50 && grade <= 5.49)

                gradeInWord = "Very good";

            else if (grade >= 5.50 && grade <= 6.00)

                gradeInWord = "Excellent";

            Console.WriteLine(gradeInWord);
        }

        public static void Main()
        {
            PrintInWord(double.Parse(Console.ReadLine()));
        }
    }
}