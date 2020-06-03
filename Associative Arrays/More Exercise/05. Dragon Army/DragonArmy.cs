
namespace _05._Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<double>>> dragons = new Dictionary<string, Dictionary<string, List<double>>>();
            
            string defaultDragonDamage = "45";
            string defaultDragonHealth = "250";
            string defaultDragonArmor = "10";
            
            for (int i = 0; i < numberOfDragons; i++)
            {
                string input = Console.ReadLine();
                string[] dragonArgs = input.Split();

                string type = dragonArgs[0];
                string name = dragonArgs[1];
                string damageAsAString = dragonArgs[2];
                string healthAsAString = dragonArgs[3];
                string armorAsAString = dragonArgs[4];

                if (damageAsAString == "null")
                {
                    damageAsAString = defaultDragonDamage;
                }
                if (healthAsAString == "null")
                {
                    healthAsAString = defaultDragonHealth;
                }
                if (armorAsAString == "null")
                {
                    armorAsAString = defaultDragonArmor;
                }

                double damage = double.Parse(damageAsAString);
                double health = double.Parse(healthAsAString);
                double armor = double.Parse(armorAsAString);

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<double>>());
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new List<double>());
                    dragons[type][name].Add(damage);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
                else
                {
                    dragons[type][name].Clear();
                    dragons[type][name].Add(damage);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, List<double>>> dragon in dragons)
            {
                string type = dragon.Key;
                double damage = 0;
                double health = 0;
                double armor = 0;
                double dragonCountInThisType = 0;

                foreach (KeyValuePair<string, List<double>> quality in dragon.Value)
                {
                    string name = quality.Key;
                    List<double> dragonQuality = quality.Value;

                    damage += dragonQuality[0];
                    health += dragonQuality[1];
                    armor += dragonQuality[2];
                    dragonCountInThisType++;
                }

                Console.WriteLine($"{type}::({damage / dragonCountInThisType:f2}/{health / dragonCountInThisType:f2}/{armor / dragonCountInThisType:f2})");

                foreach (KeyValuePair<string, List<double>> everySingleDragon in dragon.Value.OrderBy(x => x.Key))
                {
                    List<double> dragonQuality = everySingleDragon.Value;
                    string dragonName = everySingleDragon.Key;
                    int dragonDamage = (int) dragonQuality[0];
                    int dragonHealth= (int)dragonQuality[1];
                    int dragonArmor = (int)dragonQuality[2];

                    Console.WriteLine($"-{everySingleDragon.Key} -> damage: {dragonDamage}, health: {dragonHealth}, armor: {dragonArmor}");
                }
            }
        }
    }
}