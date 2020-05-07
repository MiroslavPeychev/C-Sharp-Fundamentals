namespace _11._Multiplication_Table_2._0
{
    using System;

    public class MultiplicationTable2
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplierCount = int.Parse(Console.ReadLine());

            if (multiplierCount > 10)
            {
                Console.WriteLine($"{inputNumber} X {multiplierCount} = {inputNumber * multiplierCount}");
                return;
            }

            for (int i = multiplierCount; i <= 10; i++)
            {
                Console.WriteLine($"{inputNumber} X {i} = {inputNumber * i}");
            }
        }
    }
}