namespace _01._Day_of_Week
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();

            DateTime dateTime = DateTime.ParseExact(dateAsText, "dd-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}