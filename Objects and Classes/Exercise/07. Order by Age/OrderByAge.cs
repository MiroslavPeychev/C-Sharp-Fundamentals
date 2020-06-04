namespace _07._Order_by_Age
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class OrderByAge
    {
        public static void Main()
        {
            List<HumanBeings> listOfPeople = new List<HumanBeings>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] arrayOfElements = input.Split();

                    string name = arrayOfElements[0];
                    string id = arrayOfElements[1];
                    int age = int.Parse(arrayOfElements[2]);

                    HumanBeings people = new HumanBeings(name, id, age);

                    listOfPeople.Add(people);

                }
            }

            foreach (var person in listOfPeople.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }

    public class HumanBeings
    {
        public HumanBeings(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }

        public int Age { get; private set; }

    }
}