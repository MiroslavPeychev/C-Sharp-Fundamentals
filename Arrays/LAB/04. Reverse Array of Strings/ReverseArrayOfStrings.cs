namespace _04._Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string[] reversed = input.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}