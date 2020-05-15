namespace _11._Snowballs
{
    using System;
    using System.Numerics;

    public class Snowballs
    {
        public static void Main()
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger biggestSgnowballValue = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int currentSnowballSnow = int.Parse(Console.ReadLine());
                int currentSnowballTime = int.Parse(Console.ReadLine());
                int currentSnowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = BigInteger.Pow((currentSnowballSnow / currentSnowballTime), currentSnowballQuality);

                if (biggestSgnowballValue <= currentSnowballValue)
                {
                    biggestSgnowballValue = currentSnowballValue;

                    snowballSnow = currentSnowballSnow;
                    snowballTime = currentSnowballTime;
                    snowballQuality = currentSnowballQuality;
                }

            }

            Console.WriteLine($"{snowballSnow} : {snowballTime} = {biggestSgnowballValue} ({snowballQuality})");
        }
    }
}