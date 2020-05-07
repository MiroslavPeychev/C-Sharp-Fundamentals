namespace _07._Theatre_Promotion
{
    using System;
    public class TheatrePromotion
    {
        public static void Main()
        {
            string typeOfTheDay = Console.ReadLine().ToLower();
            int personAge = int.Parse(Console.ReadLine());
            int price = 0;

            if (typeOfTheDay == "weekday")
            {
                if ((personAge >= 0 && personAge <= 18) || (personAge > 64 && personAge <= 122))
                {
                    price = 12;
                }
                else if (personAge > 18 && personAge <= 64)
                {
                    price = 18;
                }
            }

            if (typeOfTheDay == "weekend")
            {
                if ((personAge >= 0 && personAge <= 18) || (personAge > 64 && personAge <= 122))
                {
                    price = 15;
                }
                else if (personAge > 18 && personAge <= 64)
                {
                    price = 20;
                }
            }

            if (typeOfTheDay == "holiday")
            {
                if (personAge >= 0 && personAge <= 18)
                {
                    price = 5;
                }
                else if (personAge > 18 && personAge <= 64)
                {
                    price = 12;
                }
                else if (personAge > 64 && personAge <= 122)
                {
                    price = 10;
                }
            }

            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}