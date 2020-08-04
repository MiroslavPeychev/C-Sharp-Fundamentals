namespace _01._Email_Validator
{
    using System;
    using System.Linq;

    public class EmailValidator
    {
        public static void Main()
        {
            string email = Console.ReadLine();

            while (true)
            {
                string inputCommand = Console.ReadLine();
                string[] commands = inputCommand.Split();

                string command = commands[0];

                if (command == "Complete")
                {
                    break;
                }

                if (command == "Make")
                {
                    if (commands[1] == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else if (commands[1] == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(commands[1]);

                    string domain = email.Substring(email.Length - count);//email.Length - count, count
                    Console.WriteLine(domain);
                }
                else if (command == "GetUsername")
                {
                    if (email.Contains("@"))
                    {
                        int index = email.IndexOf('@');
                        string username = email.Substring(0, index);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (command == "Replace")
                {
                    char charToReplace = char.Parse(commands[1]);

                    if (email.Contains(charToReplace))
                    {
                        email = email.Replace(charToReplace, '-');                        
                    }

                    Console.WriteLine(email);
                }

                else if (command == "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        Console.Write($"{(int)email[i]} ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}