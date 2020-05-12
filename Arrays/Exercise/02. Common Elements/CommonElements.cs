namespace _02._Common_Elements
{
    using System;

    public class CommonElements
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentSecondArrElement = secondArray[i];

                for (int j = 0; j < firstArray.Length; j++)//if (firstArray.Contains(currentSecondArrElement)=>usint System.Linq;
                {
                    string currentFirstArrElement = firstArray[j];

                    if (currentSecondArrElement==currentFirstArrElement)
                    {
                        Console.Write(currentSecondArrElement + " ");
                        break;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}