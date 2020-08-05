namespace _03._Need_for_Speed_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NeedForSpeedThree
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, long> carModelsAndMileage = new Dictionary<string, long>();
            Dictionary<string, int> carModelsAndFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split('|');

                string carModel = inputInfo[0];
                long mileage = long.Parse(inputInfo[1]);
                int fuel = int.Parse(inputInfo[2]);

                if (!carModelsAndMileage.ContainsKey(carModel))
                {
                    carModelsAndMileage.Add(carModel, mileage);
                    carModelsAndFuel.Add(carModel, fuel);
                }
            }

            while (true)
            {
                string[] commandsArgs = Console.ReadLine().Split(" : ");

                string command = commandsArgs[0];

                if (command == "Stop")
                {
                    break;
                }

                if (command == "Drive")
                {
                    string carModel = commandsArgs[1];
                    long distanceTotravel = long.Parse(commandsArgs[2]);
                    int neededFuel = int.Parse(commandsArgs[3]);

                    int availableFuel = carModelsAndFuel[carModel];
                    long currentMileage = carModelsAndMileage[carModel];

                    if (availableFuel >= neededFuel)
                    {
                        carModelsAndFuel[carModel] -= neededFuel;
                        carModelsAndMileage[carModel] += distanceTotravel;

                        Console.WriteLine($"{carModel} driven for {distanceTotravel} kilometers. {neededFuel} liters of fuel consumed.");

                        if (carModelsAndMileage[carModel] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carModel}!");

                            carModelsAndMileage.Remove(carModel);
                            carModelsAndFuel.Remove(carModel);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (command == "Refuel")
                {
                    string carModel = commandsArgs[1];
                    int fuelToRefill = int.Parse(commandsArgs[2]);

                    int tankCapacity = 75;
                    int currentFuelInTheTank = carModelsAndFuel[carModel];

                    if (currentFuelInTheTank + fuelToRefill >= tankCapacity)
                    {
                        int emtySpace = tankCapacity - currentFuelInTheTank;

                        carModelsAndFuel[carModel] += emtySpace;

                        Console.WriteLine($"{carModel} refueled with {emtySpace} liters");
                    }
                    else
                    {
                        carModelsAndFuel[carModel] += fuelToRefill;

                        Console.WriteLine($"{carModel} refueled with {fuelToRefill} liters");
                    }
                }
                else if (command == "Revert")
                {
                    string carModel = commandsArgs[1];
                    long kilometers = long.Parse(commandsArgs[2]);

                    carModelsAndMileage[carModel] -= kilometers;

                    Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");

                    if (carModelsAndMileage[carModel] <= 10000)
                    {
                        carModelsAndMileage[carModel] = 10000;
                    }
                }
            }

            var sorted = carModelsAndMileage
                .OrderByDescending(x => x.Value)
                .ThenBy(c => c.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sorted)//
            {
                long mileage = kvp.Value;
                string car = kvp.Key;
                int fuel = carModelsAndFuel[car];

                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}