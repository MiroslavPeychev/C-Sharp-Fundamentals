namespace _02._Car_Race
{
    using System;
    using System.Linq;

    public class CarRace
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstRacer = numbers;
            var secondRacer = numbers
                .Reverse()
                .ToArray();

            double sumFirst = SumNumbers(firstRacer);
            double sumSecond = SumNumbers(secondRacer);                      

            if (sumFirst < sumSecond)
            {
                Console.WriteLine($"The winner is left with total time: {sumFirst}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumSecond}");
            }            
        }

        private static double SumNumbers(int[] racer)
        {
            double sum = 0;

            for (int i = 0; i < racer.Length / 2; i++)
            {                
                    if (racer[i] == 0)
                    {
                        sum *= 0.8;
                    }
                    else
                    {
                        sum += racer[i];
                    }                
            }

            return sum;
        }
    }
}