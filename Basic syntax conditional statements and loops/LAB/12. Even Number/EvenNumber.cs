namespace _12._Even_Number
{
    using System;

    public class EvenNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());


            while (true)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;

                }

                number = int.Parse(Console.ReadLine());
            }
        }
    }
}