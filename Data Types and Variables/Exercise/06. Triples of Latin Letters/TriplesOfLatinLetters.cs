namespace _06._Triples_of_Latin_Letters
{
    using System;

    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + inputNumber; first++)
            {
                for (char second = 'a'; second < 'a' + inputNumber; second++)
                {
                    for (char third = 'a'; third < 'a' + inputNumber; third++)
                    {

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        for (int q = 0; q < n; q++)
            //        {

            //            Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + q)}");
            //        }
            //    }
            //}
        }
    }
}