namespace _02._Randomize_Words
{
    using System;

    public class RandomiseWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(words.Length);
                string tempWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = tempWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}