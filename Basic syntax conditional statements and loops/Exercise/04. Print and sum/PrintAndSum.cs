namespace _04._Print_and_sum
{
    using System;
    using System.Collections.Generic;

    public class PrintAndSum
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += i;
                numbers.Add(i);
            }

            Console.WriteLine(String.Join(" ", numbers));
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
