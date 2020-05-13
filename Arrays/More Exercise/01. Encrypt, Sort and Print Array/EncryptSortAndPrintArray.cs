namespace _01._Encrypt__Sort_and_Print_Array
{
    using System;
    using System.Collections.Generic;

    public class EncryptSortAndPrintArray
    {
        public static void Main()
        {
            int numberOfSequences = int.Parse(Console.ReadLine());

            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfSequences; i++)
            {
                string currentName = Console.ReadLine();

                int currentSum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {
                    if (vowels.Contains(currentName[j]))
                    {
                        char currentVowel = currentName[j];
                        currentSum += ((int)currentVowel * currentName.Length);
                    }
                    else
                    {
                        char currentConsonant = currentName[j];
                        currentSum += ((int)currentConsonant / currentName.Length);
                    }
                }

                results.Add(currentSum);
            }

            results.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
    }
}