namespace _01._Ages
{
    using System;

    public class Ages
    {
        public static void Main()
        {
            int ages = int.Parse(Console.ReadLine());
            string result = string.Empty;

            if (ages >= 0 && ages <= 2)
            {
                result = "baby";
            }
            else if (ages >= 3 && ages <= 13)
            {
                result = "child";
            }
            else if (ages >= 14 && ages <= 19)
            {
                result = "teenager";
            }
            else if (ages >= 20 && ages <= 65)
            {
                result = "adult";
            }
            else if (ages >= 65)
            {
                result = "elder";
            }

            Console.WriteLine(result);
        }
    }
}