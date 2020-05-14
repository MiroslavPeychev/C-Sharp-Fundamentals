namespace _07._Concat_Names
{
    using System;

    public class ConcatNames
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimeter}{secondName}");
        }
    }
}