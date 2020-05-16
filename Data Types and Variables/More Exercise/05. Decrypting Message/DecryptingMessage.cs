namespace _05._Decrypting_Message
{
    using System;
    using System.Collections.Generic;

    public class DecryptingMessage
    {
        public static void Main()
        {
            int decryptingKey = int.Parse(Console.ReadLine());
            int numberOfInputLines = int.Parse(Console.ReadLine());

            List<char> decryptedMessage = new List<char>();

            for (int i = 0; i < numberOfInputLines; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                char newChar = (char)(decryptingKey + currentChar);
                decryptedMessage.Add(newChar);
            }

            Console.WriteLine(String.Join("", decryptedMessage));
        }
    }
}