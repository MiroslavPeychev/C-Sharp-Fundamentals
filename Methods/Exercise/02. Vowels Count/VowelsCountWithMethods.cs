namespace _02._Vowels_Count
{
    using System;
    using System.Linq;

    public class VowelsCountWithMethods
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            int result = VowelsCount(inputString);

            Console.WriteLine(result);
        }
        public static int VowelsCount(string inputString)
        {
            int result = 0;

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < inputString.Length; i++)
            {
                if (vowels.Contains(inputString[i]))
                {
                    result++;
                }
            }

            return result;
        }
    }
}