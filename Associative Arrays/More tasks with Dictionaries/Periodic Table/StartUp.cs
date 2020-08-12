namespace Periodic_Table
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var list = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in line)
                {
                    list.Add(item);
                }

            }

            Console.WriteLine(string.Join(" ", list.OrderBy(x => x)));
        }
    }
}