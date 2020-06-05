namespace _08._Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            foreach (string word in words)
            {
                char infront = word[0];
                char atTheBack = word[word.Length - 1];
                string numberAsString = word.Substring(1, word.Length - 2);
                int number = int.Parse(numberAsString);

                double sum = 0;
                if (char.IsUpper(infront))
                {
                    sum += number / (infront - 64.0);
                }
                else
                {
                    sum += number * (infront - 96.0);
                }

                if (char.IsUpper(atTheBack))
                {
                    sum -= (atTheBack - 64.0);
                }
                else
                {
                    sum += (atTheBack - 96.0);
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}