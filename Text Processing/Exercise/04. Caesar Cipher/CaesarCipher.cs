namespace _04._Caesar_Cipher
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CaesarCipher
    {
        public static void Main()
        {
            string inputMessage = Console.ReadLine();
            List<char> chars = inputMessage.ToList();
            List<char> encryptedMessage = new List<char>();

            for (int i = 0; i < chars.Count; i++)
            {
                int currentCharAsANumber = (int)(chars[i]);
                char newChar = (char)(currentCharAsANumber + 3);
                encryptedMessage.Add(newChar);
            }

            Console.WriteLine(string.Join("", encryptedMessage));
        }
    }
}