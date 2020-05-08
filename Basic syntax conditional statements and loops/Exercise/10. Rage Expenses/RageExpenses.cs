namespace _10._Rage_Expenses
{
    using System;

    public class RageExpenses
    {
        public static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int trashedHeadSet = 0;
            int trashedMouses = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;
            decimal rageExpenses = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadSet++;
                }

                if (i % 3 == 0)
                {
                    trashedMouses++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboard++;

                    if (trashedKeyboard % 2 == 0)
                    {
                        trashedDisplay++;
                    }
                }
            }

            rageExpenses = (trashedHeadSet * headsetPrice)
                + (trashedMouses * mousePrice)
                + (trashedKeyboard * keyboardPrice)
                + (trashedDisplay * displayPrice);

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}