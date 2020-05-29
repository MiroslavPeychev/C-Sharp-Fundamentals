namespace _03._Longer_Line
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        public static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineOne = CalculatePythagorean(Math.Pow(x2 - x1, 2), Math.Pow(y2 - y1, 2));
            double lineTwo = CalculatePythagorean(Math.Pow(x4 - x3, 2), Math.Pow(y4 - y3, 2));


            if (lineOne >= lineTwo)
            {
                PrintCloserLine(x1, y1, x2, y2);
            }
            else
            {
                PrintCloserLine(x3, y3, x4, y4);
            }
        }

        public static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {
            double line1 = CalculatePythagorean(x1, y1);
            double line2 = CalculatePythagorean(x2, y2);
            string longerLine;

            if (line1 <= line2)
            {
                longerLine = $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                longerLine = $"({x2}, {y2})({x1}, {y1})";
            }

            Console.WriteLine(longerLine);
        }
        public static double CalculatePythagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);
            return result;
        }
    }
}