namespace _01._Secret_Chat
{
    using System;

    public class SecretChat
    {
        public static void Main()
        {
            string message = Console.ReadLine();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(":|:");
                string command = commands[0];

                if (command == "Reveal")
                {
                    break;
                }

                if (command == "InsertSpace")
                {
                    int indexToInsert = int.Parse(commands[1]);

                    message = message.Insert(indexToInsert, " ");

                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substringToReverse = commands[1];

                    if (!message.Contains(substringToReverse))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        int firstIndex = message.IndexOf(substringToReverse);

                        string substr = message.Substring(firstIndex, substringToReverse.Length);

                        message = message.Remove(firstIndex, substringToReverse.Length);

                        string reversed = ReverseString(substr);

                        message = message.Insert(message.Length, reversed);

                        Console.WriteLine(message);
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substringToBeReplaced = commands[1];
                    string substringToReplace = commands[2];

                   
                    message = message.Replace(substringToBeReplaced, substringToReplace);
                    

                    Console.WriteLine(message);
                }

            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
