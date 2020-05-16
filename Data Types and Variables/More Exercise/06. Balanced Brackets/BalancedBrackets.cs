namespace _06._Balanced_Brackets
{
    using System;

    public class BalancedBrackets
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int openingBracketCounter = 0;
            int closingBrackrtCounter = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingBracketCounter++;
                }
                else if (input == ")")
                {
                    closingBrackrtCounter++;

                    if (openingBracketCounter - closingBrackrtCounter != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            string result = string.Empty;
            bool areBalanced = (openingBracketCounter == closingBrackrtCounter);

            if (areBalanced)
            {
                result = "BALANCED";
            }
            else
            {
                result = "UNBALANCED";
            }

            Console.WriteLine(result);
        }
    }
}