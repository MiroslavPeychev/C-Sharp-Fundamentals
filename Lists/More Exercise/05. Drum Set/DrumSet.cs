namespace _05._Drum_Set
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DrumSet
    {
        public static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> quality = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var originalQuality = quality.ToList();

            while (true)
            {
                string inputInfo = Console.ReadLine();

                if (inputInfo == "Hit it again, Gabsy!")
                {
                    break;
                }

                string[] tokens = inputInfo.Split();
                int currentPower = int.Parse(tokens[0]);

                for (int i = 0; i < quality.Count; i++)
                {
                    quality[i] -= currentPower;
                }

                for (int i = 0; i < quality.Count; i++)
                {
                    double cost = 0;

                    if (quality[i] <= 0)
                    {
                        cost = (originalQuality[i] * 3);

                        if (savings < cost)
                        {
                            quality.RemoveAt(i);
                            originalQuality.RemoveAt(i);
                        }
                        else
                        {
                            savings -= cost;
                            quality[i] = originalQuality[i];
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", quality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}