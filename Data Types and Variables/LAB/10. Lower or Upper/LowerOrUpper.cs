namespace _10._Lower_or_Upper
{
    using System;

    public class LowerOrUpper
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());
            bool isUpper = char.IsUpper(input);

            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}