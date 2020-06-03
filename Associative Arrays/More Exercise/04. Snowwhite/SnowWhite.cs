namespace _04._Snowwhite
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SnowWhite
    {
        public static void Main()
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                string[] dwarfArgs = input.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = dwarfArgs[0];
                string dwarHatColor = dwarfArgs[1];
                int dwarfPhysics = int.Parse(dwarfArgs[2]);

                string currentDwarf = $"{dwarfName} <:> {dwarHatColor}";

                if (!colors.ContainsKey(dwarHatColor))
                {
                    colors.Add(dwarHatColor, 1);
                }
                else
                {
                    colors[dwarHatColor]++;
                }

                if (!dwarfs.ContainsKey(currentDwarf))
                {
                    dwarfs.Add(currentDwarf, dwarfPhysics);
                }
                else
                {
                    int oldValue = dwarfs[currentDwarf];

                    if (dwarfPhysics > oldValue)
                    {
                        dwarfs[currentDwarf] = dwarfPhysics;
                    }
                }
            }

            var sortedDwarfs = dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => colors[x.Key.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedDwarfs)
            {
                string dwarfId = kvp.Key;
                int physics = kvp.Value;
                string[] dwarfIDTokens = dwarfId.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = dwarfIDTokens[0];
                string dwarfHatColor = dwarfIDTokens[1];

                Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {physics}");
            }
        }
    }
}