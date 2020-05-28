namespace _07._NxN_Matrix
{
    using System;

    public class NxNMatrix
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            PrintMatrix(sizeMatrix);
        }

        static void PrintMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size + " ");
                }

                Console.WriteLine();
            }
        }
    }
}