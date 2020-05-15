namespace _10._Poke_Mon
{
    using System;

    public class PokeMon
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedTargets = 0;
            int originalPower = pokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokedTargets++;

                if (pokePower == originalPower / 2 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}