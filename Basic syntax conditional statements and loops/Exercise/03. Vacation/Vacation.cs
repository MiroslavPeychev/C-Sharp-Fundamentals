namespace _03._Vacation
{
    using System;

    public class Vacation
    {
        public static void Main()
        {
            int numbersOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double perStudent = 0;
            double perBusinessman = 0;
            double perOneRegular = 0;

            switch (dayOfTheWeek)
            {
                case "Friday":
                    perStudent = 8.45;
                    perBusinessman = 10.90;
                    perOneRegular = 15;
                    break;
                case "Saturday":
                    perStudent = 9.80;
                    perBusinessman = 15.60;
                    perOneRegular = 20;
                    break;
                case "Sunday":
                    perStudent = 10.46;
                    perBusinessman = 16;
                    perOneRegular = 22.50;
                    break;
            }
            double finalPrice = 0;
            if (typeOfTheGroup == "Students")
            {
                finalPrice = numbersOfPeople * perStudent;
                if (numbersOfPeople >= 30)
                {
                    finalPrice = finalPrice - (finalPrice * 0.15);//=finalPrice*0.85
                }
            }
            else if (typeOfTheGroup == "Business")
            {
                finalPrice = numbersOfPeople * perBusinessman;
                if (numbersOfPeople >= 100)
                {
                    finalPrice = (numbersOfPeople - 10) * perBusinessman;
                }
            }
            if (typeOfTheGroup == "Regular")
            {
                finalPrice = numbersOfPeople * perOneRegular;
                if (numbersOfPeople >= 10 && numbersOfPeople <= 20)
                {
                    finalPrice = finalPrice - (finalPrice * 0.05);//=finalPrice*0.95
                }
            }

            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}