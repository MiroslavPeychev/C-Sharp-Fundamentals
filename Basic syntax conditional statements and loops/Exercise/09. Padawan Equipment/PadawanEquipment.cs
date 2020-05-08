namespace _09._Padawan_Equipment
{
    using System;

    public class PadawanEquipment
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            decimal finalLightSabersCount = Math.Ceiling(studentsCount * 1.10m);
            decimal priceForLightsabers = lightsaberPrice * finalLightSabersCount;
            decimal priceForRobes = robesPrice * studentsCount;
            int beltsLeft = studentsCount % 6;
            int beltsCount = studentsCount / 6 * 5 + beltsLeft;
            decimal priceForBelts = beltsCount * beltsPrice;//(studentsCount - (studentsCount / 6))*beltsPrice;

            decimal finalPriceForAll = priceForBelts + priceForLightsabers + priceForRobes;

            if (budget >= finalPriceForAll)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPriceForAll:f2}lv.");
            }
            else
            {
                decimal neededMoney = Math.Abs(finalPriceForAll - budget);
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}