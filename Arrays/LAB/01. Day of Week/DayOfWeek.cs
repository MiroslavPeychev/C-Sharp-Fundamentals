namespace _01._Day_of_Week
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            string[] days = {"Monday",
                          "Tuesday",
                          "Wednesday",
                          "Thursday",
                          "Friday",
                          "Saturday",
                          "Sunday"};

            //Console.WriteLine("Please, insert an integer number between 1 and 7");
            int day = int.Parse(Console.ReadLine());

            string result = string.Empty;

            if (day<1||day>7)
            {
                result = "Invalid day!";
            }
            else
            {
                result = $"{days[day - 1]}"; //The first day in the array is on index 0, not 1
            }

            Console.WriteLine(result);
        }
    }
}