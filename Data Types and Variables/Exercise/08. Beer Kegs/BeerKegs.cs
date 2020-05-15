namespace _08._Beer_Kegs
{
    using System;

    public class BeerKegs
    {
        public static void Main()
        {
            int numberOfinputLines = int.Parse(Console.ReadLine());
            string biggestKenModel = string.Empty;
            double kenVolume = 0;

            for (int i = 0; i < numberOfinputLines; i++)
            {
                string currentKegModel = Console.ReadLine();
                double currentKegRadius = double.Parse(Console.ReadLine());
                int currentKegHeight = int.Parse(Console.ReadLine());
                //V= π * r ^ 2 * h.
                double currentKenVolume = Math.PI * (Math.Pow(currentKegRadius, 2)) * currentKegHeight;

                if (currentKenVolume > kenVolume)
                {
                    kenVolume = currentKenVolume;
                    biggestKenModel = currentKegModel;
                }
            }
            Console.WriteLine(biggestKenModel);
        }

    }
}