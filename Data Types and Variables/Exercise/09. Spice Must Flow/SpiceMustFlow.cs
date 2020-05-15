namespace _09._Spice_Must_Flow
{
    using System;

    public class SpiceMustFlow
    {
        public static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spiceMined = 0;

            int dropDownYieldConstant = 10;
            int workersConsume = 26;
            int days = 0;

            while (startingYield >= 100)
            {
                spiceMined += startingYield;
                spiceMined -= workersConsume;
                startingYield -= dropDownYieldConstant;
                days++;
            }

            if (spiceMined != 0)
            {
                spiceMined -= workersConsume;
            }

            Console.WriteLine(days);
            Console.WriteLine(spiceMined);
        }
    }
}