namespace _08._Triangle_of_Numbers
{
    using System;

    public class TriangleOfNumbers
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int row = 1; row <= inputNumber; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }

                Console.WriteLine();
            }
        }
    }
}