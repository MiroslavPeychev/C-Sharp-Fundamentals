namespace _08._Town_Info
{
    using System;

    public class TownInfo
    {
        public static void Main()
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}