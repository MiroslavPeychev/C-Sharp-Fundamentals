using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = string.Empty;
            string surfacePattern = "^[^A-Za-z0-9]+$";
            string mantlePattern = "^[0-9_]+$";
            string multiPattern = "^([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";

            bool isAllFine = true;
            int coreLength = -1;

            for (int index = 1; index <= 5; index += 1)
            {
                lines = Console.ReadLine();
                string currentPattern = string.Empty;
                if (index == 1 || index == 5)
                {
                    currentPattern = surfacePattern;
                }
                else if (index == 2 || index == 4)
                {
                    currentPattern = mantlePattern;
                }
                else
                {
                    currentPattern = multiPattern;
                }

                Regex regex = new Regex(currentPattern);
                if (regex.IsMatch(lines) && index == 3)
                {
                    coreLength = regex.Match(lines).Groups
                    ["core"].Value.Length;
                }
                if(!regex.IsMatch(lines))
                {
                    isAllFine = false;
                }

            }
            if (isAllFine)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
