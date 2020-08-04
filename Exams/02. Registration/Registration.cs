namespace _02._Registration
{
    using System;
    using System.Text.RegularExpressions;

    public class Registration
    {
        public static void Main()
        {
            Regex regex = new Regex(@"(U\$)([A-Z][a-z]{2,})\1(P@\$)([A-Za-z]{5,}\d+)\3");
            int countOfInputs = int.Parse(Console.ReadLine());
            int successfulRegistrationsCount = 0;

            for (int i = 0; i < countOfInputs; i++)
            {
                string loginString = Console.ReadLine();
                Match match = regex.Match(loginString);


                if (match.Success)
                {
                    var username = match.Groups[2];
                    var password = match.Groups[4];
                    
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");

                    successfulRegistrationsCount++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}