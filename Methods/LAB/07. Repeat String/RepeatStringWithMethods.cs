namespace _07._Repeat_String
{
    using System;
    using System.Text;

    public class RepeatStringWithMethods
    {
        public static void Main()
        {
            string inputStr = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatString(inputStr, count);

            Console.WriteLine(result);
        }

        private static string RepeatString(string inputStr, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(inputStr);
            }

            return result.ToString();
        }
    }
}