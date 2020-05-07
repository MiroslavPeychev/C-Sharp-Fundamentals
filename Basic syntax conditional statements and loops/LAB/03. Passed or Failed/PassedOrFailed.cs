namespace _03._Passed_or_Failed
{
    using System;

    public class PassedOrFailed
    {
        public static void Main()
        {
            double studentGrade = double.Parse(Console.ReadLine());
            string passOrFaild = string.Empty;

            if (studentGrade >= 3.00)
            {
                passOrFaild = "Passed!";
            }
            else
            {
                passOrFaild = "Failed!";
            }

            Console.WriteLine(passOrFaild);
        }
    }
}