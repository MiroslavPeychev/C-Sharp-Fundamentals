namespace _05._Messages
{
    using System;

    public class Messages
    {
        public static void Main()
        {
            int clicks = int.Parse(Console.ReadLine());
            string typedMessage = string.Empty;

            for (int i = 0; i < clicks; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = digits[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    typedMessage += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }

                int numberInAscciTable = offset + digitLength - 1;
                typedMessage += (char)(numberInAscciTable + 97);
            }

            Console.WriteLine(typedMessage);
        }
    }
}