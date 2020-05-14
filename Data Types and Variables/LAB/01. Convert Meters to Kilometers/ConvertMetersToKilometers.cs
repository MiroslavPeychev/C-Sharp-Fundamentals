namespace _01._Convert_Meters_to_Kilometers
{
    using System;

    public class ConvertMetersToKilometers
    {
        public static void Main()
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = 0;

            kilometers = meters / 1000;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}