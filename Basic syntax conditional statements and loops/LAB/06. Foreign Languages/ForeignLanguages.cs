namespace _06._Foreign_Languages
{
    using System;

    public class ForeignLanguages
    {
        public static void Main()
        {
            string Country = Console.ReadLine();
            switch (Country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}