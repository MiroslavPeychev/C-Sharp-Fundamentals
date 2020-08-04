namespace _03._Inbox_Manager
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class InboxManager
    {
        public static void Main()
        {
            Dictionary<string, List<string>> usersAndEmails = new Dictionary<string, List<string>>();
            
            while (true)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split("->");

                if (commands[0] == "Statistics")
                {
                    break;
                }

                string command = commands[0];
                string username = commands[1];

                if (command == "Add")
                {
                    if (!usersAndEmails.ContainsKey(username))
                    {
                        usersAndEmails.Add(username, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }

                if (command == "Send")
                {
                    string email = commands[2];

                    usersAndEmails[username].Add(email);
                }

                if (command == "Delete")
                {
                    if (usersAndEmails.ContainsKey(username))
                    {
                        usersAndEmails.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
            }

            int usersCount = usersAndEmails.Keys.Count();
            //var sortedUsers = usersAndEmails
            //    .OrderByDescending(user => user.Value.Count)
            //    .ThenBy(user => user.Key)
            //    .ToList();

            Console.WriteLine($"Users count: {usersCount}");

            foreach (var kvp in usersAndEmails.OrderByDescending(y=>y.Value.Count).ThenBy(x=>x.Key))
            {
                string user = kvp.Key;
                List<string> emails = kvp.Value;

                Console.WriteLine(user);

                foreach (var email in emails)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}