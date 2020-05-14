namespace _04._Centuries_to_Minutes
{
    using System;

    public class CenturiesToMinutes
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            //•	Assume that a year has 365.2422 days at average (the Tropical year).
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}