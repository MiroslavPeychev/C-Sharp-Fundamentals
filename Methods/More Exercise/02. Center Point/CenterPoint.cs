namespace _02._Center_Point
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintCloserLine(x1, y1, x2, y2);
        }

        public static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {
            double lineOne = CalculatePythagorean(x1, y1);
            double lineTwo = CalculatePythagorean(x2, y2);
            string smallerLine;
            
            if (lineOne <= lineTwo)
            {
                smallerLine = $"({x1}, {y1})";
            }
            else
            {
                smallerLine = $"({x2}, {y2})";
            }

            Console.WriteLine(smallerLine);
        }

        public static double CalculatePythagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);

            return result;
        }
    }
}