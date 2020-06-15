namespace Hornet_Comm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class HornetComm
    {
        public static void Main()
        {
            string privateMessagePattern = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";

            List<string> privateMessages = new List<string>();
            List<string> broadcastMessages = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }

                Match privateMessage = Regex.Match(input, privateMessagePattern);
                Match broadcast = Regex.Match(input, broadcastPattern);

                if (privateMessage.Success)
                {
                    string recipientCodeInput = string.Join("", privateMessage.Groups[1].Value.Reverse());

                    string message = privateMessage.Groups[2].Value;

                    privateMessages.Add(recipientCodeInput + " -> " + message);
                }

                if (broadcast.Success)
                {
                    string frequencyInput = broadcast.Groups[2].Value;
                    string frequency = "";

                    for (int i = 0; i < frequencyInput.Length; i++)
                    {
                        if (char.IsUpper(frequencyInput[i]))
                        {
                            frequency += frequencyInput[i].ToString().ToLower();
                        }
                        else
                        {
                            frequency += frequencyInput[i].ToString().ToUpper();
                        }
                    }

                    string message = broadcast.Groups[1].Value;

                    broadcastMessages.Add(frequency + " -> " + message);
                }
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcastMessages.Count > 0 ? string.Join(Environment.NewLine, broadcastMessages) : "None");
            Console.WriteLine("Messages:");
            Console.WriteLine(privateMessages.Count > 0 ? string.Join(Environment.NewLine, privateMessages) : "None");
        }
    }
}