namespace _01._Data_Type_Finder
{
    using System;
    using System.Numerics;

    public class DataTypeFinder
    {
        public static void Main()
        {
            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    break;
                }

                bool isInteger = BigInteger.TryParse(inputLine, out BigInteger integer);
                bool isBoolen = bool.TryParse(inputLine, out bool boolean);
                bool isDecimal = double.TryParse(inputLine, out double floatingPoint);
                bool isCharacter = char.TryParse(inputLine, out char character);

                if (isInteger)
                {
                    Console.WriteLine($"{inputLine} is integer type");
                }
                else if (isDecimal)
                {
                    Console.WriteLine($"{inputLine} is floating point type");
                }
                else if (isCharacter)
                {
                    Console.WriteLine($"{inputLine} is character type");
                }
                else if (isBoolen)
                {
                    Console.WriteLine($"{inputLine} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{inputLine} is string type");
                }
            }
        }
    }
}