namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VehicleCatalogue
    {
        public static void Main()
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split();
                string type = tokens[0].ToLower();

                if (type == "car")
                {
                    type = "Car";
                }
                else
                {
                    type = "Truck";
                }

                string model = tokens[1];
                string colour = tokens[2];
                int power = int.Parse(tokens[3]);
                Vehicle vehicle = new Vehicle();

                vehicle.vehicleType = type;
                vehicle.vehicleModel = model;
                vehicle.vehicleColour = colour;
                vehicle.vehicleHorsepower = power;
                listOfVehicles.Add(vehicle);
            }

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = listOfVehicles.Where(x => x.vehicleModel == command).First();
                Console.WriteLine($"Type: {vehicle.vehicleType}");
                Console.WriteLine($"Model: {vehicle.vehicleModel}");
                Console.WriteLine($"Color: {vehicle.vehicleColour}");
                Console.WriteLine($"Horsepower: {vehicle.vehicleHorsepower}");

                command = Console.ReadLine();
            }

            if (listOfVehicles.Where(x => x.vehicleType == "Car").Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {listOfVehicles.Where(x => x.vehicleType == "Car").Select(x => x.vehicleHorsepower).Average():f2}.");
            }
            else 
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00."); 
            }

            if (listOfVehicles.Where(x => x.vehicleType == "Truck").Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {listOfVehicles.Where(x => x.vehicleType == "Truck").Select(x => x.vehicleHorsepower).Average():f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }

    public class Vehicle
    {
        public string vehicleType { get; set; }

        public string vehicleModel { get; set; }

        public string vehicleColour { get; set; }

        public int vehicleHorsepower { get; set; }
    }
}