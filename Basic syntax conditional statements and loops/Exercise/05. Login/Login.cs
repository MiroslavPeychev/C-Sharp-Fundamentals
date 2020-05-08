namespace _05._Login
{
    using System;

    public class Login
    {
        public static void Main()
        {
            string userName = Console.ReadLine();
            string passWord = string.Empty;


            for (int i = userName.Length - 1; i >= 0; i--)
            {
                passWord += userName[i];
            }

            int incorrectPasswordCounter = 0;

            bool isLoggedIn = false;

            while (incorrectPasswordCounter < 4)
            {
                string inputPassword = Console.ReadLine();

                if (passWord == inputPassword)
                {
                    isLoggedIn = true;
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (incorrectPasswordCounter != 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                incorrectPasswordCounter++;
            }

            if (!isLoggedIn)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}