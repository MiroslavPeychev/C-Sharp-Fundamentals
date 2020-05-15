namespace _03._Elevator
{
    using System;

    public class Elevator
    {
        public static void Main()
        {
            int passangers = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = passangers / elevatorCapacity;
            bool hasAnExtraCourse = passangers % elevatorCapacity != 0;

            if (hasAnExtraCourse)
            {
                courses++;
            }

            Console.WriteLine(courses);

            //OR
            //int courses = (int)Math.Ceiling((double)passangers/elevatorCapacity);
            //Console.WriteLine(courses);

        }
    }
}