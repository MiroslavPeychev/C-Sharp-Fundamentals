namespace _01._Data_Types
{
    using System;

    public class DataTypes
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            int numberAsInt = 0;
            double numberAsDouble = 0;
            string text = string.Empty;

            switch (type)
            {
                case "int":
                    Integer(numberAsInt);
                    break;
                case "real":
                    Double(numberAsDouble);
                    break;
                case "string":
                    TextMethod(text);
                    break;
            }
        }

        public static void Integer(int numberAsInt)
        {
            numberAsInt = int.Parse(Console.ReadLine());
            Console.WriteLine(numberAsInt * 2);
        }

        public static void Double(double numberAsDouble)
        {
            numberAsDouble = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(numberAsDouble * 1.5):f2}");
        }

        public static void TextMethod(string text)
        {
            text = Console.ReadLine();
            Console.WriteLine($"${text}$");
        }
    }
}
