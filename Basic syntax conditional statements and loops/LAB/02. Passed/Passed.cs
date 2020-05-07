namespace _02._Passed
{
    using System;

    public class Passed
    {
        public static void Main()
        {
            float studentGrade = float.Parse(Console.ReadLine());

            if (studentGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}