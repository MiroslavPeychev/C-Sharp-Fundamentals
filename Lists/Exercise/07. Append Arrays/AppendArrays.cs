namespace _07._Append_Arrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class AppendArrays
    {
        public static void Main()
        {
            List<string> items = Console.ReadLine()
                .Split('|')
                .ToList(); // chetem lista

            items.Reverse(); //obryshtame go

            var result = new List<string>(); //pravim si prazen spisyk

            foreach (var item in items) // za vseki element ot lista
            {
                List<string> nums = item
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList(); //vseki element go vkarvame v nov spisyk i mahame izlishnite prazni mesta, dori da sa powveche ot edno

                result.AddRange(nums); //dobavqme celiq spisyk v noviq prazen naj-gore
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}