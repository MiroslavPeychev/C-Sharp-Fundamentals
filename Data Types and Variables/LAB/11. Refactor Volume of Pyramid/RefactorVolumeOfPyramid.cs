namespace _11._Refactor_Volume_of_Pyramid
{
    using System;

    public class RefactorVolumeOfPyramid
    {
        public static void Main()
        {


            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());

            double pyramidVolume = (length * width * heigth) / 3;

            Console.WriteLine($"Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}