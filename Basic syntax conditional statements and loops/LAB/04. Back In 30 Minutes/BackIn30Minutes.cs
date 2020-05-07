namespace _04._Back_In_30_Minutes
{
    using System;

    public class BackIn30Minutes
    {
        public static void Main()
        {
            //Console.WriteLine("Please enter an integer number between 0 and 23 for hours:");
            int hours = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter an integer number between 0 and 59 for minutes:");

            int minutes = int.Parse(Console.ReadLine());

            DateTime someDate = new DateTime(1, 1, 1, hours, minutes, 0);
            someDate = someDate.AddMinutes(30);

            Console.WriteLine($"{someDate.Hour}:{someDate.Minute:D2}");
        }
    }
}