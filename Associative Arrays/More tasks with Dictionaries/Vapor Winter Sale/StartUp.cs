namespace Vapor_Winter_Sale
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var gameDLC = new Dictionary<string, string>();
            var gamePrice = new Dictionary<string, double>();

            string input = Console.ReadLine();

            foreach (var item in input.Split(", "))
            {
                if (item.Contains('-'))
                {
                    string[] tokens = item.Split('-');
                    string game = tokens[0];
                    double price = double.Parse(tokens[1]);

                    if(!gamePrice.ContainsKey(game))
                    {
                        gamePrice.Add(game, price);
                    }

                    if(!gameDLC.ContainsKey(game))
                    {
                        gameDLC[game] = "";
                    }
                }
                else if (item.Contains(':'))
                {
                    string[] tokens = item.Split(':');
                    string game = tokens[0];
                    string DLC = tokens[1]; 

                    if(gameDLC.ContainsKey(game))
                    {
                        gameDLC[game] = DLC;
                        gamePrice[game] *= 1.2;
                    }
                }
            }

            foreach (var kvp in gameDLC)
            {
                if(gameDLC[kvp.Key] == "")
                {
                    gamePrice[kvp.Key] *= 0.80;
                }
                else
                {
                    gamePrice[kvp.Key] /=2.0d;
                }
            }

            foreach (var kvp in gamePrice.OrderBy(x=>x.Value))
            {
                if(gameDLC[kvp.Key] != "")
                {
                    Console.WriteLine($"{kvp.Key} - {gameDLC[kvp.Key]} - {kvp.Value:f2}");
                }
            }

            foreach (var kvp in gamePrice.OrderByDescending(x=>x.Value))
            {
                if(gameDLC[kvp.Key] == "")
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value:f2}");
                }
            }

        }
    }
}