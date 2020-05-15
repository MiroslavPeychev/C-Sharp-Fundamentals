namespace _07._Water_Overflow
{
    using System;

    public class WaterOverflow
    {
        public static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int totalLitersInTank = 0;

            for (int i = 0; i < inputLines; i++)
            {
                int waterToAdd = int.Parse(Console.ReadLine());

                if (totalLitersInTank + waterToAdd <= tankCapacity)
                {
                    totalLitersInTank += waterToAdd;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(totalLitersInTank);
        }
    }
}