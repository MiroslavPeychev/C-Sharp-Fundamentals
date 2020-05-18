namespace _04._Printing_Triangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintFigure(inputNumber);
        }

        public static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }

         public static void PrintFigure(int inputNumber)
        {
            for (int row = 1; row <= inputNumber; row++)
            {
                PrintLine(row);
            }

            for (int row = inputNumber - 1; row >= 1; row--)
            {
                PrintLine(row);
            }
        }
    }
}