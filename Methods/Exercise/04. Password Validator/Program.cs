namespace _04._Password_Validator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string password = Console.ReadLine();
            bool isBetween6And10Simbols = CheckLenghtOfPassword(password);

            if (isBetween6And10Simbols == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool containsOnlyDigitsAndLetters = ContainsOnlyDigitsAndLetters(password);

            if (containsOnlyDigitsAndLetters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool containsMin2Digits = CheckMinDigit(password);

            if (containsMin2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetween6And10Simbols && containsOnlyDigitsAndLetters && containsMin2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckMinDigit(string password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char simbol = password[i];

                if (char.IsDigit(simbol))
                {
                    count++;
                }
            }
            return count >= 2 ? true : false;
            //if(count >= 2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        private static bool ContainsOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {

                char simbol = password[i];

                if (!char.IsLetterOrDigit(simbol))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckLenghtOfPassword(string password)
        {
            //return password.Length >= 6 && password.Length <= 10 ? true : false; Пример за тернарен оператор(замества if else конструкцията.
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}