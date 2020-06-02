namespace _03._Legendary_Farming
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LegendaryFarming
    {
        public static void Main()
        {
            Dictionary < string, long> keyMaterials = new Dictionary<string, long>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            Dictionary < string, long> junkMaterials = new Dictionary<string, long>();
            bool isKeymaterials = true;

            while (isKeymaterials)
            {
                var input = Console.ReadLine().Split().ToList();

                for (int i = 0; i < input.Count; i += 2)
                {
                    long quantity = long.Parse(input[i]);

                    string material = input[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            switch (material)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;

                            }

                            keyMaterials[material] -= 250;
                            isKeymaterials = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }

            keyMaterials = keyMaterials
                .OrderBy(x => x.Key)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, long> kvp in keyMaterials)
            {
                string keyMaterial = kvp.Key;
                long quantity = kvp.Value;

                Console.WriteLine($"{keyMaterial}: {quantity}");
            }

            junkMaterials = junkMaterials
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, long> kvp in junkMaterials)
            {
                string junkMaterial = kvp.Key;
                long quantity = kvp.Value;

                Console.WriteLine($"{junkMaterial}: {quantity}");
            }
        }
    }
}