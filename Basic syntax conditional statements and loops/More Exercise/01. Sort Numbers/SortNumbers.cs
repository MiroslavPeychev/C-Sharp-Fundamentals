namespace _01._Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            int number = 0;
            List<int> listOfnumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                number = int.Parse(Console.ReadLine());
                listOfnumbers.Add(number);
            }

            var sortedNumbers = listOfnumbers.OrderByDescending(l => l);

            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}