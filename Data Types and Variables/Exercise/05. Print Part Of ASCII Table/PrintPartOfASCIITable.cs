namespace _05._Print_Part_Of_ASCII_Table
{
    using System;

    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int startAsciiCode = int.Parse(Console.ReadLine());
            int endAsciiCode = int.Parse(Console.ReadLine());

            for (int i = startAsciiCode; i <= endAsciiCode; i++)
            {
                int currentCharacter = i;
                Console.Write($"{(char)(currentCharacter)} ");
            }

            Console.WriteLine();

            //OR
            //for (char i = (char)startAsciiCode; i <= endAsciiCode; i++)
            //{
            //    Console.Write(i+" ");
            //}
        }
    }
}