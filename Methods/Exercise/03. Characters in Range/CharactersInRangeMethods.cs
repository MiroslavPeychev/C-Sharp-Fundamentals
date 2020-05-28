namespace _03._Characters_in_Range
{
    using System;

    public class CharactersInRangeMethods
    {
        public static void Main()
        {
            char startCharacter = char.Parse(Console.ReadLine());
            char endCharacter = char.Parse(Console.ReadLine());

            string result = CharactersInRange(startCharacter, endCharacter);

            Console.WriteLine(result);
        }
        public static string CharactersInRange(char startCharacter, char endCharacter)
        {
            string result = string.Empty;

            for (int i = Math.Min(startCharacter, endCharacter) + 1; i < Math.Max(startCharacter, endCharacter); i++)
            {
                result += ((char)i + " ");
            }

            return result;
        }
    }
}