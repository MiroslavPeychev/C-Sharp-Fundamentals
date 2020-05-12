namespace _01._Train
{
    using System;
    using System.Linq;

    public class Train
    {
        public static void Main()
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] passangers = new int[numberOfWagons];

            for (int i = 0; i < numberOfWagons; i++)
            {
                int currentWagonPassangers = int.Parse(Console.ReadLine());

                passangers[i] = currentWagonPassangers;
            }

            int allPassangersCount = passangers.Sum();

            Console.WriteLine(string.Join(" ", passangers));
            Console.WriteLine(allPassangersCount);
        }
    }
}